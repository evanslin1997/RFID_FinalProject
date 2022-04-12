import random



numStr = '1234567890'
alphabetStr = 'ABCDEF'

randStr = ''
for i in range(32):
    random.seed()
    if random.randint(1, 3) % 3 == 0:
        randStr += random.choice(alphabetStr)
    else:
        randStr += random.choice(numStr)

print(randStr)