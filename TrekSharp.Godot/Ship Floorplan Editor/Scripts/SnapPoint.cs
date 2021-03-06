using Godot;
using System;
using System.Linq;

public class SnapPoint : Area2D {
    public float Radius => this.Shape != null && this.Shape is CircleShape2D ? ((CircleShape2D)this.Shape).Radius : 0;

    public Shape2D Shape {get; private set;}

    public void Show(bool show) {
        foreach (var sprite in this.GetChildren().OfType<Sprite>()) {
            sprite.Visible = show;
        }
    }

    public bool IsChildOf(Dragable dragable) {
        Node node = this;
        Node parent = node.GetParent();
        while (parent != null) {
            if (parent == dragable) {
                return true;
            } else {
                node = parent;
                parent = node.GetParent();
            }
        }
        return false;
    }

    public override void _Ready() {
        Shape = this.ShapeOwnerGetShape(0,0);
    }

    public void OnEnter(Node node) {
        if (node is Dragable) {
            ((Dragable)node).SnapTo(this);
        }
    }

    public void OnExit(Node node) {
        if (node is Dragable) {
            ((Dragable)node).Unsnap(this);
        }
    }
}