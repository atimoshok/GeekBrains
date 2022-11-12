# Создайте программу для игры в "Крестики-нолики".

import random

def print_field():
    current_field = [[0, 0, 0], [0, 0, 0], [0, 0, 0]]
    for row in range(0, len(field)):
        for cal in range(0, len(field[row])):
            if field[row][cal] == 0:
                current_field[row][cal] = '-'
                # print(field)
                # print(current_field)
            elif field[row][cal] == 1:
                current_field[row][cal] = 'X'
            elif field[row][cal] == -1:
                current_field[row][cal] = 'O'
            print(current_field[row][cal], end=' ')
        print()
    for row in range(0, len(field)):
        for cal in range(0, len(field[row])):
            if field[row][cal] == 0:
                current_field[row][cal] = '-'
            elif field[row][cal] == 1:
                current_field[row][cal] = 'X'
            elif field[row][cal] == -1:
                current_field[row][cal] = 'O'
            print(field[row][cal], end=' ')
        print()

def change_player():
    if current_player == first_player:
        return second_player
    else:
        return first_player

def if_win():
    row_sum = 0
    cal_sum = 0
    for row in range(0, len(field)):
        for cal in range(0, len(field[row])):
            row_sum += field[row][cal]
        if row_sum == 3 or row_sum == -3:
            return True
        else:
            return False
            break
            
    # for cal in range(0, len(field)):
    #     for row in range(0, len(field[cal])):
    #         cal_sum += field[cal][row]
    #     if cal_sum == 3 or cal_sum == -3:
    #         return True
    #     else:
    #         return False
    #         break

field = [[0, 0, 0], [0, 0, 0], [0, 0, 0]]
print_field()
first_player = 'X'
second_player = 'O'
current_player = random.choice([first_player, second_player])
print(f'Первым ходит {current_player}')
while True:
    current_row = int(input(f'{current_player}, Укажите ряд, в который хотите поставить символ (1-3): '))
    current_cal = int(input((f'{current_player}, Укажите столбец, в который хотите поставить символ (1-3): ')))
    if current_player == first_player:
        field[current_row - 1][current_cal - 1] = 1
    else:
        field[current_row - 1][current_cal - 1] = -1
    print_field()
    if if_win():
        break
    current_player = change_player()
print(f'Победил {current_player}')