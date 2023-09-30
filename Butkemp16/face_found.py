import cv2

face_cascades = cv2.CascadeClassifier(cv2.data.haarcascades + "haarcascade_frontalface_default.xml")
img = cv2.imread("Karolain.jpg")
img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
faces = face_cascades.detectMultiScale(img_gray)
img_found = cv2.imread("Karolain.jpg")
for (x, y, w, h) in faces:
    cv2.rectangle(img_found, (x, y), (x + w, y + h), (150, 90, 255), 1)
while True:
    cv2.imshow("Result", img)
    cv2.imshow("Result_Found", img_found)
    if cv2.waitKey(1) & 0xff == ord('q'):
        break