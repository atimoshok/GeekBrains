# Вычислить число Пи c заданной точностью d

# Пример:
# при $d = 0.001, π = 3.141.$    $10^{-1} ≤ d ≤10^{-10}$

from math import pi

def pi_leibnits():
    pi_num = 0
    for x in range(100):
        pi_num = pi_num + 1/((2 * x + 1) * (-3)**x)
    pi_num *= 12**(1/2)
    return pi_num

d = float(input('Задайте необходимую точность вычисления Пи (10^(-1) ≤ d ≥ 10^(-10)): '))
count_degree = 0
while d != 1:
    d *= 10
    count_degree += 1

print(f'{round(pi_leibnits(), count_degree)} - число Пи c точностью {count_degree} знаков после запятой')
print(f'{pi} - число Пи из библиотеки Math')
