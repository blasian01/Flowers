import random

# Set the size of the flowers
width = 5
height = 5

# Set the characters to use for the petals and the center
petal_characters = "@#*"
center_character = "O"

# Create the flowers
for i in range(10):
    flower = ""
    for j in range(height):
        for k in range(width):
            if j == 0 or j == height - 1:
                # Use the petal characters for the top and bottom rows
                flower += random.choice(petal_characters)
            elif k == 0 or k == width - 1:
                # Use the petal characters for the first and last columns
                flower += random.choice(petal_characters)
            else:
                # Use the center character for the rest of the flower
                flower += center_character
        flower += "\n"
    print(flower)
