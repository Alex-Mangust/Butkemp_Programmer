import cv2

face_cascades = cv2.CascadeClassifier(cv2.data.haarcascades + "haarcascade_frontalface_default.xml")
img = cv2.imread("Karolain.jpg")
img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
faces = face_cascades.detectMultiScale(img_gray)
for (x, y, w, h) in faces:
    cv2.rectangle(img, (x, y), (x + w, y + h), (0, 0, 255), 2)
while True:
    cv2.imshow("Result", img)
    if cv2.waitKey(1) & 0xff == ord('q'):
        break

# cap = cv2.VideoCapture("video.mp4")

# while True:
#     __, frame = cap.read()
#     cv2.imshow("Camera", frame)

#     if cv2.waitKey(1) & 0xff ==ord('q'):
#         break
