# Даны два файла, в каждом из которых находится запись многочлена. Задача - сформировать файл, содержащий сумму многочленов.

def remove_symbols(user_list):
    for elem in user_list:
        if elem == '+':
            user_list.remove(elem)
    user_list.pop()
    user_list.pop()
    return user_list


def get_degree(elem):
    x_position = elem.find('x')
    if x_position == -1:
        return 0
    else:
        if len(elem) - 1 > x_position:
            return int(elem[x_position + 2:])
        else:
            return 1


def get_coefficient(elem):
    x_position = elem.find('x')
    if x_position == -1:
        return int(elem)
    else:
        if x_position == 0:
            return 1
        else:
            return int(elem[:x_position - 1])


def polinom_to_dictionary(path):
    with open(path, 'r') as f:
        polinom = list(f.read().split())
    #print(polinom)
    remove_symbols(polinom)
    #print(polinom)
    dictionary = {}
    for elem in polinom:
        dictionary[get_degree(elem)] = get_coefficient(elem)
    return dictionary


def join_dictionaries(first_dictionary, second_dictionary):
    result_dictionary = {}
    for i in first_dictionary.keys():
        if i in second_dictionary:
            result_dictionary[i] = first_dictionary[i] + second_dictionary[i]
        else:
            result_dictionary[i] = first_dictionary[i]

    for i in second_dictionary.keys():
        if i not in result_dictionary:
            result_dictionary[i] = second_dictionary[i]
    return result_dictionary

def sort_dictionary(dictionary):
    result_dictionary = {}
    while len(dictionary) != 0:
        result_dictionary[min(dictionary.keys())] = dictionary[min(dictionary.keys())]
        dictionary.pop(min(dictionary.keys()))
    return result_dictionary

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

first_dictionary = polinom_to_dictionary(r'C:\Users\atimo\OneDrive\Рабочий стол\GB\Python\Homework\2710_DZ\polinom1.txt')
with open(r'C:\Users\atimo\OneDrive\Рабочий стол\GB\Python\Homework\2710_DZ\polinom1.txt', 'r') as f:
    print(f'{f.read()} - первый многочлен')

second_dictionary = polinom_to_dictionary(r'C:\Users\atimo\OneDrive\Рабочий стол\GB\Python\Homework\2710_DZ\polinom2.txt')
with open(r'C:\Users\atimo\OneDrive\Рабочий стол\GB\Python\Homework\2710_DZ\polinom2.txt', 'r') as f:
    print(f'{f.read()} - второй многочлен')

result_dictionary = join_dictionaries(first_dictionary, second_dictionary)
result_dictionary = sort_dictionary(result_dictionary)

polinomial = ['= 0']
for i in result_dictionary:
    polinomial.append(make_elem(result_dictionary[i], i))
polinomial.reverse()
print('Сумма многочленов:')
print_polinomial(polinomial, r'Python\Homework\2710_DZ\result_polinom.txt')