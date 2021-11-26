# Unity Utilities - General
A collection of general purpose extensions and utility classes. Some notable ones are listed below.

## Quick Start
> See the releases or the [CHANGELOG](./Packages/com.smaleck.utilities-general/CHANGELOG.md) for the current version.

To use this package in your Unity project, you have to manually add it to you `manifest.json`.

1. Go to `YourProject/Packages/`
2. Open `manifest.json`
3. Add this packages git repository to the dependencies object in the JSON:

### Example:
```json
{
  "dependencies": {
    "com.smaleck.utilities-general": "git://github.com/SMaleck/unity-utilities-general.git#v1.1.0"
  }
}
```

## EnumExtensions
Extensions to allow easy access to the next or pervious value of an `enum`.
The regular variant will always return the same value, when reaching the edge of the `enum` values. 
The `Next/PreviousWrap` variants will wrap around on the edges.

## EnumIterator
Static utility to allow easy iteration over all values of an `enum`. 
Includes convenience method to exclude certain values.

## Range
A small class holding two values of any type, representing a range. In effect a slightly more type-safe named Tuple.
The `IReadOnlyRange<T>` interface allow to expose it as a read-only variant as well.

## Logging
Includes a simple static logger with `Log`, `Warn` and `Error` methods. It is effectively just a wrapper around Unity's built-in `UnityEngine.Debug.Log` logger.
The benefit is that it will extract the caller name and prefix any log message with that, to automatically improve log formatting a bit. There is an instantiable wrapper around the static variant, which should be preferred in scenarios where you want to make your code more unit testable or utilize a dependency injection framework.

## NonDrawingGraphic
A `MonoBehaviour` that inherits from `MaskableGraphic` and skips drawing. This can be used to have invisible hitboxes for UI elements, like buttons in world space, or to block input without a visible sprite. Or anything else you can come up with, of course.

Credit goes to [Slipp Douglas Thompson](https://gist.github.com/capnslipp/349c18283f2fea316369)
