import math

lengthX = int(input("Enter X length: "))
lengthY = int(input("Enter Y length: "))
numberOfSquaresY = int(input("Enter number of squares at Y: "))

singleSquareSize = math.floor(lengthY / numberOfSquaresY)

rangeX = math.floor(lengthX / singleSquareSize)
rangeY = math.floor(lengthY / singleSquareSize)

suns = 0
moons = 0
print()
for i in range(rangeY):
    for j in range(rangeX):
        if (i % 2 == 0):
            if (j % 2 == 0):
                print(1, end=" ")
                suns += 1
            else:
                print(0, end=" ")
                moons += 1
        else:
            if (j % 2 == 0):
                print(0, end=" ")
                moons += 1
            else:
                print(1, end=" ")
                suns += 1

        if (j + 1 == rangeX):
            print()
print()    

print("Number of moons: {}, number of suns: {}".format(moons, suns))

sum = moons + suns
print("Sum of squares: {}".format(sum))