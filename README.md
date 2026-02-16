# Interfaces Demo

C# Demo for OOP principles 

* Interfaces
    * IShape defines the contract for all shapes.
    * Shows programming to abstraction: the processor works with IShape without knowing concrete types.
    * Circle implements IShape directly, demonstrating that completely unrelated shapes can still conform to the same contract without inheritance.
* Abstraction
    * RegularPolygon is an abstract class providing:
      * Shared implementation for GetPerimeter()
      * Common properties like Sides and SideLength
      * An abstract GetArea() method
    * Demonstrates hiding implementation details while enforcing a contract.
* Inheritance
    * Concrete shapes (Square, Triangle, Octagon) inherit from RegularPolygon.
    * They override the abstract GetArea() method.
    * Shows code reuse and how shared behavior is centralized.
* Polymorphism
    * ShapeProcessor processes a list of IShape objects without knowing their concrete types.
    * Demonstrates runtime polymorphism.
