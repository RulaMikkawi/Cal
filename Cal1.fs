open System
 
 let Sum ( x1 : string) ( x2 : string) string = "x1" + "x2"

  let x1= Console.ReadLine() 
  let x2 = Console.ReadLine()
 

let x11 =
   match x1 with
   | Some x1 -> x1 
   | None -> "0"

let x22 =
   match x2 with
   | Some x2 -> x2 
   | None -> "0"



printf " the result is %s" Sum(x1,x2)

Console.ReadLine() |> ignore

