// using statement to be able to call the UI for WinForms
// make sure to add the reference dll for System.Windows.Forms
open System.Windows.Forms

// function to house the method for calling a new windows forms object
let app() = Application.Run(new Form())
// function to house the method for Enabling Visual Styles for keyboard and mouse event bindings
let visual() = Application.EnableVisualStyles()
// A console writeline for in case the windows form could not load properly
let failCase() = printf "Could not load the Windows Form"

// F# version of a while loop, or the real use case of being a recursive function (a function that calls itself)
let rec Program loop = 
    // if loop is not true then print the fail statement, else call on Enable visual styles
    let looping = if not loop then failCase() else visual()
    // calls for the new form to load
    app()
 
 // now the main function / method runProgram will actually call the Program function which takes a boolean parameter
let runProgram = Program(true)