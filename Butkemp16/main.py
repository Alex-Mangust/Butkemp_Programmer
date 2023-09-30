import cv2

# img = cv2.imread(r'C:\Users\Саня\Desktop\Учеба\Основной блок\Буткемп программирование\Butkemp_Programmer\Butkemp16\test.jpg')
img = cv2.imread('test.jpg')
# print(img.shape)
img = cv2.resize(img, (625, 484))
cv2.imshow("Result", img)
cv2.waitKey(0)