import qrcode
import sys

password = sys.argv[1]

img = qrcode.make(password)

img.save("password_qr.png")

print("QR_GENERATED")