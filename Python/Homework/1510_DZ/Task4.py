# Напишите программу, которая будет преобразовывать десятичное число в двоичное.

# Пример:
# - 45 -> 101101
# - 3 -> 11
# - 2 -> 10

def convert_decimal(decimal_num, basis=2):
    result_list = []
    #div_reminder = decimal_num
    while decimal_num != 0:
        #print(decimal_num % basis)
        result_list.append(decimal_num % basis)
        decimal_num = decimal_num // basis
    result_list.reverse()
    return result_list


user_number = int(input('Введите десятичное число: '))
print(f'Десятичное число {user_number} в двоичной системе =', end=" ")
for i in convert_decimal(user_number):
    print(i, end="")
