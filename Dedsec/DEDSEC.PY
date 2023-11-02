import time
import os

def clear():
    if os.name == 'nt':
        os.system('cls')
    else:
        os.system('clear')

def print_animation(frames, delay):
    for frame in frames:
        clear()
        print(frame)
        time.sleep(delay)

frames = [
'''
           ___
  _____   /   \___
 /     \_/         \\
|                    |
 \    O   PYHOOMA   /
  \                 /
   \               /
    `._         _.'
       `~-----~`
''',
'''
           ___
  _____   /   \___
 /     \_/         \\
|                    |
 \    O   PYHOOMA   /
  \        DEDSEC   /
   \               /
    `._         _.'
       `~-----~`
''',
'''
           ___
  _____   /   \___
 /     \_/         \\
|                    |
 \    O   PYHOOMA   /
  \        DEDSEC   /
   \               /
    `._    --+  _.'
       `~-----~`
''',
'''
           ___
  _____   /   \___
 /     \_/         \\
|                    |
 \    O   PYHOOMA   /
  \        DEDSEC   /
   \     .-.     /
    `._ /   \_.'
       `~-----~`
''',
'''
           ___
  _____   /   \___
 /     \_/         \\
|                    |
 \    O   PYHOOMA   /
  \        DEDSEC   /
   \    .-' `-._ /
    `._/       \_.'
       `~-----~`
'''
]

print_animation(frames, 0.3)
