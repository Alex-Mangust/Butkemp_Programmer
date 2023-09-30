import cv2

cap = cv2.VideoCapture("video.mp4")

while True:
    __, frame = cap.read()
    cv2.imshow("Camera", frame)

    if cv2.waitKey(1) & 0xff ==ord('q'):
        break
