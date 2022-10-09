# Напишите программу для. проверки истинности утверждения
# ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

def logical_statement(X, Y, Z):
    left_part = not (X or Y or Z)
    right_part = not (X) and not (Y) and not (Z)
    return left_part == right_part

flag = True
print('Утвержденине ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z\nX Y Z')
for x in range(2):
    for y in range(2):
        for z in range(2):
            result = logical_statement(x, y, z)
            print(x, y, z, result)
            if result != True:
                flag = False

print(f'Утвержджение для всех значений {flag}')
print('P.S. По закону де Моргана: Отрицание дизъюнкции есть конъюнкция отрицаний :)')
