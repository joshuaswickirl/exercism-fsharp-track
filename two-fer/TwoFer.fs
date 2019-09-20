module TwoFer

let twoFer (input: string option): string =
    let input = defaultArg input "you"
    sprintf "One for %s, one for me." input
