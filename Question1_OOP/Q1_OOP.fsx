open System

// Base class
type Shape() =

    // Virtual method
    abstract member Area: unit -> float

// Derived class: Circle
type Circle(radius: float) =
    inherit Shape()

    // Override Area method
    override this.Area() =
        Math.PI * radius * radius

// Derived class: Rectangle
type Rectangle(length: float, breadth: float) =
    inherit Shape()

    // Override Area method
    override this.Area() =
        length * breadth

// Create objects
let circle = Circle(5.0)
let rectangle = Rectangle(10.0, 4.0)

// Display individual object results
printfn "----- OOP: Shape Area Calculation -----"

printfn "Circle Area: %.2f" (circle.Area())

printfn "Rectangle Area: %.2f" (rectangle.Area())

// Demonstrate polymorphism
printfn "\n----- Demonstrating Polymorphism -----"

let shapes: Shape list =
    [ circle :> Shape
      rectangle :> Shape ]

shapes
|> List.iter (fun shape ->
    printfn "Area: %.2f" (shape.Area())
)
