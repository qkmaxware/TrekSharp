using Godot;
using System;
using System.Linq;
using System.Collections.Generic;

public class Dragable : KinematicBody2D {
    
    private bool isDragging = false;
    private bool lockDrag = false;

    private List<SnapPoint> possible_points = new List<SnapPoint>(); // Snapping will be to the closest snap point

    public override void _Ready() {
    
    }

    public void StartDrag() {
        lockDrag = true;
    }

    public virtual Vector2 GetSnapOffset() {
        return new Vector2(0,0);
    } 

    public override void _Process(float delta) {
        if (IsAcceptingInput()) {
            // Basic movement
            var mousepos = GetGlobalMousePosition();
            this.GlobalPosition = new Vector2(mousepos.x, mousepos.y) + GetSnapOffset();
            // Snapping behavior
            Vector2 snap;
            if (IsOverSnapPoint(mousepos, out snap)) {
                this.GlobalPosition = new Vector2(snap.x, snap.y) + GetSnapOffset();
            }
        }
    }
    
    public void SnapTo(SnapPoint point) {
        if (!point.IsChildOf(this)) {
            possible_points.Add(point);
        }
    }

    public void Unsnap(SnapPoint point) {
        possible_points.Remove(point);
    }

    public bool IsOverSnapPoint(Vector2 mouse, out Vector2 snap) {
        // Get closest snap point
        SnapPoint closest = null;
        float closestDistance = float.PositiveInfinity;
        foreach (var point in this.possible_points) {
            var snapDistanceFromCursor = mouse.DistanceTo(point.GlobalPosition);
            if (snapDistanceFromCursor < closestDistance) {
                closest = point;
                closestDistance = snapDistanceFromCursor;
            }
        }

        if (closest != null) {
            snap = new Vector2(closest.GlobalPosition.x, closest.GlobalPosition.y);
            var snapDistanceFromCursor = mouse.DistanceTo(closest.GlobalPosition);
            if (snapDistanceFromCursor > closest.Radius) {
                return false;
            } else {
                return true;
            }
        } else {
            snap = new Vector2();
            return false;
        }
    }

    public void OnNodeInput(Viewport viewport, InputEvent @event, int shape_idx) {
        if (@event is InputEventMouseButton) {
            var mouse = (InputEventMouseButton)@event;
            if(mouse.ButtonIndex == (int)ButtonList.Left && mouse.Pressed) {
                this.isDragging = true;
                this.lockDrag = false;
            }
        }
    }

    private static float wrap(float val, float min, float max){
        val = val - (float)Math.Round((val - min) / (max - min)) * (max - min);
        if (val < 0)
            val = val + max - min;
        return val;
    }

    public bool IsAcceptingInput() {
        return isDragging || lockDrag;
    }

    public override void _UnhandledInput(InputEvent @event) {
        if (@event is InputEventMouseButton) {
            var mouse = (InputEventMouseButton)@event;
            if(mouse.ButtonIndex == (int)ButtonList.Left && mouse.Pressed) {
                // Click anywhere
            } else {
                this.isDragging = false;
                this.lockDrag = false;
            }
        } else if (@event is InputEventKey) {
            var key = (InputEventKey)@event;
            if (IsAcceptingInput()) {
                // Q, E rotate things while you are dragging it
                if (key.Pressed && key.Scancode == (int)KeyList.Q) {
                    this.RotationDegrees = wrap(this.RotationDegrees - 45, -180, 180);
                }
                if (key.Pressed && key.Scancode == (int)KeyList.E) {
                    this.RotationDegrees = wrap(this.RotationDegrees + 45, -180, 180);
                }

                if (key.Pressed && key.Scancode == (int)KeyList.Delete) {
                    this.QueueFree();
                }
            }
        }
    }
}