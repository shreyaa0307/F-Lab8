
open System

// Base class
type Shape() =
    abstract member Area: unit -> float

    default this.Area() = 0.0

// Derived class: Circle
type Circle(radius: float) =
    inherit Shape()

    override this.Area() =
        Math.PI * radius * radius

// Derived class: Rectangle
type Rectangle(length: float, width: float) =
    inherit Shape()

    override this.Area() =
        length * width

// Main program
[<EntryPoint>]
let main argv =

    printfn "===== OOP IN F# ====="

    // Create objects
    let circle = Circle(5.0)
    let rectangle = Rectangle(10.0, 5.0)

    // Display individual results
    printfn "\nCircle Area: %.2f" (circle.Area())
    printfn "Rectangle Area: %.2f" (rectangle.Area())

    // Demonstrate polymorphism
    let shapes: Shape list = [
        circle :> Shape
        rectangle :> Shape
    ]

    printfn "\n----- Polymorphism -----"

    shapes
    |> List.iter (fun shape ->
        printfn "Shape Area: %.2f" (shape.Area())
    )

    printfn "\nProgram completed successfully!"

    0
