# Задана натуральная степень k.
# Сформировать случайным образом список коэффициентов (значения от 0 до 100) многочлена и записать в файл многочлен степени k.

# Пример:
# k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0
import random


def make_elem(ratio, degree):
    if (ratio == 0):
        return None
    elif (degree == 0):
        elem = str(ratio)
    elif (degree == 1):
        if (ratio == 1):
            elem = 'x'
        else:
            elem = str(ratio) + '*x'
    elif (ratio == 1):
        elem = 'x^' + str(degree)
    else:
        elem = str(ratio) + '*x^' + str(degree)
    return elem


def print_polinomial(lst, file_name=r'Python\Homework\2710_DZ\k_degree_polinomial.txt'):
    f = open(file_name,'w')
    for i in range(len(lst) - 2):
        print(lst[i], end=' + ')
        f.write(lst[i] + ' + ')
    print(lst[-2] + ' ' + lst[-1])
    f.write(lst[-2] + ' ' + lst[-1])
    f.close()


k = int(input('Введите степень многочлена: '))
dict = {}
for i in range(k + 1):
    dict[i] = random.randint(0, 100)
polinomial = ['= 0']
for i in dict:
    if (make_elem(dict[i], i) != None):
        polinomial.append(make_elem(dict[i], i))
polinomial.reverse()
print(dict)
print_polinomial(polinomial)
