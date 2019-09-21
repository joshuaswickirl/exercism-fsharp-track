module QueenAttack

let create (position: int * int): bool = 
    (fst position < 8 && fst position > 0) && (snd position < 8 && snd position > 0)

let canAttack (queen1: int * int) (queen2: int * int) = 
    (fst queen1 = fst queen2) ||
    (snd queen1 = snd queen2) ||
    (fst queen1 - fst queen2 |> abs) = (snd queen1 - snd queen2 |> abs)
