# Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.



def simple_multipliers(num):
    with open(r'Python\Homework\2710_DZ\simple_nums.txt', 'r') as f:
        simple_numbers = list(map(int, f.read().split()))
    #print(simple_numbers)
    if num in simple_numbers:
        print(f'Число {num} простое')
    else:
        current_simple_multipliers = []
        for i in simple_numbers:
            if i > num:
                #print(i)
                break
            current_simple_multipliers.append(i)
        #print(current_simple_multipliers)
        multipliers = []
        while num != 1:
            for i in current_simple_multipliers:
                if (num % i == 0):
                    num /= i
                    multipliers.append(i)
                    break
        return multipliers


N = int(input('Введите натуральное число N: '))
print(f'Cписок простых множителей числа N: {simple_multipliers(N)}')

