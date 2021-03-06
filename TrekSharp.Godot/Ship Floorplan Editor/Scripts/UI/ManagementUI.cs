using Godot;
using System;

public class ManagementUI : Camera2D {

    [Export] public int Speed = 40;

    private int horizontal = 0;
    private int vertical = 0;

    private bool show_anchors = true;

    public override void _Process(float delta) {
        this.Position += new Vector2(horizontal, vertical) * Speed * delta;
    }

    public override void _Input(InputEvent evt) {
        horizontal = 0;
        vertical = 0;

        if (Input.IsKeyPressed((int)KeyList.D)) {
            horizontal = 1;
        } else if (Input.IsKeyPressed((int)KeyList.A)) {
            horizontal = -1;
        }

        if (Input.IsKeyPressed((int)KeyList.W)) {
            vertical = -1;
        } else if (Input.IsKeyPressed((int)KeyList.S)) {
            vertical = 1;
        }

        if (Input.IsKeyPressed((int)KeyList.Tab)) {
            this.show_anchors = !this.show_anchors;
            var root = this.GetTree().Root;
            foreach (var door in GameObject.ChildrenOf<Door>(root)) {
                door.Show(this.show_anchors);
            }
            if (!this.show_anchors) {
                ((CanvasLayer)GetNode("../CanvasLayer")).Scale = new Vector2(0,0);
            } else {
                ((CanvasLayer)GetNode("../CanvasLayer")).Scale = new Vector2(1,1);
            }
        }
    }

    public void OnCreateResource(string resource) {
        if (string.IsNullOrEmpty(resource)) {
            return;
        }

        var node = GameObject.Instantiate("res://" + resource);
        this.GetTree().Root.AddChild(node);
        if (node is Dragable) {
            // Immediately start dragging these parts to place them
            var door = ((Dragable)node);
            door.StartDrag();
            if (node is Room) {
                ((Room)door).ShowDoors(this.show_anchors);
            }
        }
    }

}