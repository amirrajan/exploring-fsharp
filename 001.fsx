type Person =
  { FirstName : string; LastName : string; }
  member this.FullName = this.FirstName + " " + this.LastName
  member this.Greet other = other.FirstName + " " + other.LastName + " says hello to " + this.FullName


let person = { FirstName = "Amir"; LastName = "Rajan" }

let otherPerson = {
  FirstName = "John"
  LastName = "Doe"
}

printfn "%s" (person.Greet otherPerson)
