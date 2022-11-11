# Напишите программу, удаляющую из текста все слова, содержащие "абв"

input_text = "приветабв здравствуй абв аб абв дурахман иабвбн абвхотаб"
result_text = [word for word in input_text.split() if "абв" not in word]
print(f'Исходный текст: {input_text}')
print('Текст без слов, содержащих "абв": ', end='')
print(*result_text)
