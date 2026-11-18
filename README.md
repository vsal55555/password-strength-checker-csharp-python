# 🔐 Password Strength Checker with QR Code Generator

A desktop application built using **C# WinForms** and **Python** that analyzes password strength, provides security recommendations, generates secure passwords and creates QR codes for generated passwords.

---

## 🚀 Features

### Password Analysis

✅ Password Strength Validation

✅ Uppercase Letter Check

✅ Lowercase Letter Check

✅ Numeric Digit Check

✅ Special Character Check

✅ Minimum Length Validation

✅ Common Password Detection

✅ Password Security Suggestions


---

### Password Generation

✅ Generate Strong Random Passwords

✅ 20-Character Secure Password Creation

✅ Copy Generated Password

✅ Passphrase Expansion (Future Improvement)

---

### QR Code Integration

✅ Generate QR Code for Passwords

✅ Python-Based QR Generation

✅ Display QR Code in C# WinForms

✅ Save QR Code as PNG

✅ Choose Custom Save Location

---

## 🏗️ Project Architecture

```text
┌────────────────────┐
│   C# WinForms UI   │
└─────────┬──────────┘
          │
          ▼
Password Validation Engine
          │
          ▼
Generate Strong Password
          │
          ▼
      Python Script
          │
          ▼
Generate QR Code
          │
          ▼
Load QR Code into UI
          │
          ▼
Save QR Image
```

---

## 🛠️ Technologies Used

| Technology | Purpose |
|------------|----------|
| C# | Desktop Application |
| .NET 10 | Application Framework |
| WinForms | User Interface |
| Python | QR Code Generation |
| qrcode | QR Code Library |
| Pillow | Image Processing |
| Git | Version Control |
| GitHub | Source Code Hosting |

---

## 📷 Application Screenshots

### Main Application

<img width="833" height="589" alt="image" src="https://github.com/user-attachments/assets/133d15d4-4726-4718-b6fb-206c6aa859f9" />


### Password Validation

<img width="835" height="591" alt="image" src="https://github.com/user-attachments/assets/df348bb0-180d-4379-b9cf-2d8aff6f0e17" />


### QR Code Generation

<img width="837" height="589" alt="image" src="https://github.com/user-attachments/assets/3bb5836c-4b3f-4c74-86cc-1f64cce64301" />


---

## ⚙️ Python Setup

Install required packages:

```bash
pip install qrcode[pil]
```

Verify installation:

```bash
pip list
```

Required packages:

```text
qrcode
pillow
```

---

## 🔒 Password Strength Rules

The application validates:

- Minimum 12 Characters
- Uppercase Letters
- Lowercase Letters
- Numbers
- Special Characters
- Common Password Detection

Example:

```text
Password123!
```

Result:

```text
Strong
```

---

## 🔳 QR Code Generation Workflow

1. Generate secure password
2. Send password from C# to Python
3. Python generates QR code
4. QR code displayed in WinForms
5. User can save QR image anywhere

---

## 📂 Project Structure

```text
PasswordStrengthChecker/
│
├── PasswordStrengthChecker.sln
│
├── Forms
│   └── frmPasswordChecker.cs
│
├── PythonScripts
│   └── generate_qr.py
│
├── Assets
│   └── common_passwords.txt
│
├── GeneratedQR
│   └── PasswordQR.png
│
└── README.md
```

---

## 🎯 Learning Outcomes

Through this project I learned:

- C# WinForms Development
- Object-Oriented Programming
- Password Security Concepts
- Secure Password Generation
- Python Integration with C#
- Process Handling
- QR Code Generation
- File Management
- Git and GitHub Workflow

---

## 🔮 Future Improvements

- Passphrase Generator
- Password History
- Password Vault
- Password Encryption
- Dark Mode UI
- SQLite Database Storage
- Windows Authentication Integration
- Google Passkey Inspired Mode

---

## 👨‍💻 Author

### Bishal Shrestha

⭐ If you found this project useful, please consider giving the repository a star.
