module Leap

let leapYear (year: int): bool = 
    
    let isDivisibleBy (num: int) (year: int): bool =
        year % num = 0
    
    isDivisibleBy 4 year && (not (isDivisibleBy 100 year) || isDivisibleBy 400 year)
