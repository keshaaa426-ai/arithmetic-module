
module Arithmetic

// Қосу функциясы
let add (numbers: float list) =
    if List.isEmpty numbers then
        Error "Массив бос!"
    elif List.exists (fun x -> x < 0.0 || System.Double.IsNaN(x) || System.Double.IsInfinity(x)) numbers then
        Error "Қате мән! Теріс немесе жарамсыз сан."
    else
        Ok (List.sum numbers)

// Азайту функциясы
let subtract (numbers: float list) =
    if List.isEmpty numbers then
        Error "Массив бос!"
    elif List.exists (fun x -> x < 0.0 || System.Double.IsNaN(x) || System.Double.IsInfinity(x)) numbers then
        Error "Қате мән!"
    else
        Ok (List.reduce (-) numbers)

// Көбейту функциясы
let multiply (numbers: float list) =
    if List.isEmpty numbers then
        Error "Массив бос!"
    elif List.exists (fun x -> x < 0.0 || System.Double.IsNaN(x) || System.Double.IsInfinity(x)) numbers then
        Error "Қате мән!"
    else
        Ok (List.reduce (*) numbers)

// Бөлу функциясы
let divide (numbers: float list) =
    if List.isEmpty numbers then
        Error "Массив бос!"
    elif List.exists (fun x -> x < 0.0 || System.Double.IsNaN(x) || System.Double.IsInfinity(x)) numbers then
        Error "Қате мән!"
    elif List.tail numbers |> List.exists (fun x -> x = 0.0) then
        Error "Нөлге бөлуге болмайды!"
    else
        Ok (List.reduce (/) numbers)
