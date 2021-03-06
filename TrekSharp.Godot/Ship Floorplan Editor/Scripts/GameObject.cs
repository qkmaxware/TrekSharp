using Godot;
using System;
using System.Collections.Generic;


public static class GameObject {

    public static Node Instantiate(string resourcePath) {
        var scene = (PackedScene)GD.Load(resourcePath);
        return scene.Instance();
    }

    public static void Destroy(Node node) {
        //node.GetParent().RemoveChild(node);
        node.QueueFree();
    }

    public static IEnumerable<T> ChildrenOf<T>(Node node) where T:Node {
        foreach (Node child in node.GetChildren()) {
            if (child is T) {
                yield return (T)child;
            }
            foreach (T sub_child in ChildrenOf<T>(child)) {
                yield return sub_child;
            }
        }
    }   

}