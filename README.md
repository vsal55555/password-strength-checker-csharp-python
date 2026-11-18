# 🔐 Password Strength Checker with QR Code Generator

A desktop application built using **C# WinForms** and **Python** that analyzes password strength, provides security recommendations, generates secure passwords, estimates password entropy, and creates QR codes for generated passwords.

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

### Security Metrics

✅ Password Entropy Calculation

✅ Estimated Crack Time

✅ Security Score Evaluation

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

_Add Screenshot Here_

### Password Validation

_Add Screenshot Here_

### QR Code Generation

_Add Screenshot Here_

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

## 📊 Entropy Calculation

Entropy is calculated based on:

- Character Pool Size
- Password Length
- Password Complexity

Examples:

| Password | Entropy |
|-----------|----------|
| 123456 | Low |
| Password123 | Medium |
| Password123! | High |
| Random 20 Character Password | Very High |

---

## 📈 Crack Time Estimation

Estimated attack resistance:

```text
Instantly
Minutes
Hours
Days
Months
Years
Centuries
```

Based on calculated entropy values.

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
