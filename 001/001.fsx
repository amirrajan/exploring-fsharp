//Here is the person type with two functions,
//one to print out the full name,
//on to say hello
type Person =
  { FirstName : string; LastName : string; }
  member this.FullName = this.FirstName + " " + this.LastName
  member this.Greet other = other.FirstName + " " + other.LastName + " says hello to " + this.FullName


//if you initialize a person class on a single line
//you have to put `;` between each property
//all properties are required.
let person = { FirstName = "Amir"; LastName = "Rajan" }

//if you initialize properties on seperate lines,
//the `;` is not needed
let otherPerson = {
  FirstName = "John"
  LastName = "Doe"
}

//here is how you print a string
printfn "%s" (person.Greet otherPerson)


//here is how you print the entire type information
printfn "%A" person
printfn "%A" otherPerson

//here is how you create a new person from another person
//changing only one property and keeping the rest the same

let otherPersonWife = { otherPerson with FirstName = "Jane" }

printfn "%A" otherPersonWife
printfn "%s" otherPersonWife.FullName
