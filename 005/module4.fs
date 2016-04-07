module Module4

open Module3
open Module2

let sayHello _ = (sayHelloModule3 ()) + (sayHelloModule2 ())
