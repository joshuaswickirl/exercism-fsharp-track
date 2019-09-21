module QueenAttack

let create (row: int, col: int): bool = 
    (row < 8 && row > 0) && (col < 8 && col > 0)

let canAttack (queen1: int * int) (queen2: int * int) = 
    let row_queen1, col_queen1 = queen1
    let row_queen2, col_queen2 = queen2
    (row_queen1 = row_queen2) 
    || (col_queen1 = col_queen2) 
    || (row_queen1 - row_queen2 |> abs) = (col_queen1 - col_queen2 |> abs)
