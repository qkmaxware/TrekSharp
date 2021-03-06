using Godot;
using System;
using System.Linq;
using System.Collections.Generic;

public class Room : Dragable {
	private List<Door> doors;

	private int doorIndex = 0;
	private Door snappingDoor => (doorIndex >= 0 && doorIndex < doors.Count) ? doors[doorIndex] : null;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		base._Ready();
		doors = getDoors().ToList();
	}

	private IEnumerable<Door> getDoors() {
		foreach (Node child in GetChildren()) {
			if (child is Door)
				yield return (Door)child;
			
			foreach (Node subchild in child.GetChildren()) {
				if (subchild is Door)
					yield return (Door)subchild;
			}
		}
	}

	public void NextDoor() {
		this.doorIndex ++;
		if (this.doorIndex >= doors.Count) {
			this.doorIndex = 0;
		}
	}

	public void PreviousDoor() {
		this.doorIndex --;
		if (this.doorIndex < 0) {
			this.doorIndex = doors.Count - 1;
		}
	}

	public override Vector2 GetSnapOffset() {
		if (snappingDoor == null) {
			return base.GetSnapOffset();
		} else {
			var doorGlobal = snappingDoor.GlobalPosition;
			var meGlobal = this.GlobalPosition;

			return meGlobal - doorGlobal; // Snap offset is towards the door, this should work if no rotation exists
		}
	}

	public void ShowDoors(bool show) {
		foreach (var door in this.doors) {
			door.Show(show);
		}
	}

	public override void _UnhandledInput(InputEvent @event) { 
		base._UnhandledInput(@event);
		if (@event is InputEventKey) {
			var key = (InputEventKey)@event;
			if (IsAcceptingInput()) {
				// R, F change the active door
				if (key.Pressed && key.Scancode == (int)KeyList.R) {
					PreviousDoor();
				}
				if (key.Pressed && key.Scancode == (int)KeyList.F) {
					NextDoor();
				}
			}
		}
	}
}
