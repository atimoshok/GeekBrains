# Напишите программу для. проверки истинности утверждения
# ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

def logical_statement(X, Y, Z):
    left_part = not(X or Y or Z)
    right_part = not(X) and not(Y) and not(Z)
    print(f'{left_part == right_part}, при X = {X}, Y = {Y}, Z = {Z}')

print('Утвержденине ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z')

logical_statement(0,0,0)
logical_statement(0,0,1)
logical_statement(0,1,0)
logical_statement(0,1,1)
logical_statement(1,0,0)
logical_statement(1,0,1)
logical_statement(1,1,0)
logical_statement(1,1,1)

print('По закону де Моргана: Отрицание дизъюнкции есть конъюнкция отрицаний :)')