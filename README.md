# 🪟 Windows Forms Desktop App

A simple and interactive **Windows Forms Application** built using **C# (.NET Framework)** that allows users to fill out a form and send the data to a local **Node.js backend server**. Perfect for learning how desktop apps can interact with backend APIs!

> 🔗 **Looking for the backend server?** Check out our Node.js Backend Server: [https://github.com/fatima-amani/Windows-Forms-App-Backend-Server](https://github.com/fatima-amani/Windows-Forms-App-Backend-Server)

## 🧰 Features

- 📝 Submit name, email, phone, GitHub profile, and stopwatch time
- ⏱️ Built-in stopwatch timer
- 🔁 Navigate through submissions
- ❌ Delete entries via backend API
- 📡 Communicates with a Node.js + Express backend

## 🛠️ Requirements

- 🪟 Windows OS
- 🧱 [.NET Framework](https://dotnet.microsoft.com/en-us/download/dotnet-framework) (typically 4.7+)
- 💻 [Visual Studio](https://visualstudio.microsoft.com/) (recommended)
- 🔌 Running instance of the [backend server](https://github.com/fatima-amani/Windows-Forms-App-Backend-Server)

## 🚀 How to Run

1. **Clone the repository:**
   ```bash
   git clone https://github.com/fatima-amani/Windows-Forms-Desktop-App
   ```

2. **Open the .sln file in Visual Studio.**

3. **Build the solution (Ctrl+Shift+B).**

4. **Make sure the Backend Server is running at:**
   ```
   http://localhost:3000
   ```

5. **Run the application (F5 or click the green Start button).**

## 🔄 App Workflow

1. Fill in your Name, Email, Phone, and GitHub link
2. Use the stopwatch to track a time (e.g., coding challenge)
3. Click **Submit** to save data via backend
4. Use **Next** to navigate through stored entries
5. Click **Delete** to remove a submission

All data is stored locally on the backend in a `db.json` file.

## 🌐 Backend API Integration

This app connects to:
- 🔗 [Windows-Forms-App-Backend-Server](https://github.com/fatima-amani/Windows-Forms-App-Backend-Server)

APIs used:
- `POST /submit` - Submit form data
- `GET /read?index=x` - Read entry at specific index
- `DELETE /del?index=x` - Delete entry at specific index
- `GET /ping` - Health check for backend server

## 🖥️ Project Structure



## 🧑‍💻 Developer Tips

- Make sure CORS settings are handled correctly if using cross-domain communication.
- You can customize form fields or add validations in the Form Designer.
- Remember to start the backend server before running the application.
- The application uses `HttpClient` for API communication.

## 👩‍💻 Author

**Fatima Amani**  
GitHub: [@fatima-amani](https://github.com/fatima-amani)

## 💡 Future Enhancements (Ideas)

- 🌍 Host backend on cloud for remote API
- 📥 Export submissions as CSV or PDF
- 🔐 Add input validation and field highlighting
- 🎨 Improve UI with modern .NET UI frameworks like WPF or MAUI
- 🔒 Add authentication for secure data handling
- 📊 Add data visualization for submissions

## 🌟 Show Some Love

If you liked this project, consider giving it a ⭐ on GitHub!
