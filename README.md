# Godot-CustomResources
Godot plugin that registers custom C# Resources &amp; Nodes (Based off Atlinx/wmigor's implementation)

Essentially, it does exactly the same as the original implementations, but I've tried to make its use a little more 'natural, like it's part of the engine. Some naming conventions have been changed, so say goodbay to Creedence Clearwater Revival (CCR)!

> This plugin is for Godot 3.x!

## List of changes

1. **Naming conventions**: CCR (Custom Resource Register, not Creedence) button text was changed to just Register.
2. **Naming conventions**: RegisteredType attribute was changed to Register.
3. **Namespaces**: The RegisteredType (now Register) attribute was moved to the Godot namespace. You no longer have to import another namespace in order to use the attribute.
4. **Namespaces**: Both the plugin and the settings classes were moved to its own namespace CustomResourcesPlugin, but they're still part of the Godot namespace.
5. **Misc**: Plugin project settings were moved to the Mono section as Custom Resources.
6. **Misc**: The icon field on the RegisteredType (now Register) attribute was moved at the end. You now have to specify first the base type, instead of the icon.

## Example usage

Just use the attribute in your desired class, as you normally would do with any other attribute:
```C#
using Godot; // <-- The attribute is now stored in here!

// Registers a custom type with 
// the name of your node/resource, in this case "MyCustomNode",
// a base type, in this case "Node2D",
// an icon located at "res://custom_icon.png"
[Register(nameof(MyCustomNode), nameof(Node2D), "res://custom_icon.png")]
public class MyCustomNode : Node2D
{
	...
}
```

## Original work

Get the original base plugin from [wmigor](https://github.com/wmigor/godot-mono-custom-resource-register)

Get the original plugin from [Atlinx](https://github.com/Atlinx/Godot-Mono-CustomResourceRegistry)
