# Example for Polymorphism : a drawing application

Let's assume that we are in a drawing application, where we can make circles, rectangles, lines, curves and other graphic objects. 

- State: position, orientation, line color, area color, etc.

- Behavior: move, rotate, resize, draw, etc.

Some of these structures and behaviors are exactly the same for all graphic objects: position, move

Others vary according to the graphic object: draw, resize

## Scheme

Define in a base class the similarities of behavior and state, called `GraphicObject`. Defind attributes and methods common to all objects of the subclasses. The subclasses include `Rectangle`, `Circle`, `Straight`, `Curve`, etc.

## Using it

Since the method `move` was not redefined within the `Rectangle` class, the invoked method is the one defined in the `GraphicObject` class.

If it had been redefined, the redefined method would have been invoked.

Within the method `move`, we have the invocation to the method `draw`, which was redefined.

How do we know which `draw` is invoked?

Precisely because of late binding, we know that the draw invoked corresponds to the object for which `move` was invoked.

Recall the old definition of `this` : a reference to the object whose method is invoked, and not necessarily to an object of the class whose code is executed.

## Edited from the original example

From the example, a `Point` class was also added in order to have an attribute for the `GraphicObject` class.

Another way of writing code is to make the `GraphicObject` as an **abstract** class and there should not be any instance of it.
