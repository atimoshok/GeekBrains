# Реализуйте алгоритм перемешивания списка.
import random


def mix_list(input_list):
    result_list = []
    for i in range(len(input_list)):
        random_elem = random.randint(0, len(input_list) - 1)
        result_list.append(input_list[random_elem])
        input_list.remove(input_list[random_elem])
    return result_list


lst = [5, 2, 4, 6, 10, 55, 11, 1]
print(f'{lst} - Исходный спиисок')
print(f'{mix_list(lst)} - Перемешанный список')
