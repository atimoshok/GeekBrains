# Задайте последовательность чисел.
# Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности.

def remove_duplicates(lst):
    result_list = []
    for elem in lst:
        if elem not in result_list:
            result_list.append(elem)
    return result_list

def count_duplicates(lst):
    my_dictionary = {}
    for i in lst:
        if (my_dictionary.get(i) == None):
            my_dictionary[i] = 1
        else:
            my_dictionary[i] += 1
    result = []
    for i in my_dictionary:
        if my_dictionary[i] == 1:
            result.append(i)
    return result

user_sequence = list(map(int, input('Задайте последовательность чисел через пробел: \n').split()))
print(f'{remove_duplicates(user_sequence)} - последовательность без дубликатов')
print(f'{count_duplicates(user_sequence)} - только элементы, которые встречаются 1 раз')
