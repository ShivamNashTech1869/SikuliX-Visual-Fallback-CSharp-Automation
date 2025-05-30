# SeleniumAutomation

A robust .NET-based test automation framework built using Selenium WebDriver, SpecFlow (BDD), NUnit, and enhanced with SikuliX for visual fallback testing.

---

## 🔧 Tech Stack

- **Language**: C# (.NET 7.0)
- **Test Runner**: NUnit
- **BDD Framework**: SpecFlow
- **Browser Driver**: ChromeDriver
- **Reporting**: Allure, Extent Reports
- **Visual Automation**: SikuliX (Integrated for fallback testing)

---

## 📂 Project Structure
```bash
SeleniumAutomation/
├── Base/ # Common setup like driver init & fallback logic
├── Hooks/ # SpecFlow hooks for driver lifecycle
├── PageObjects/ # Page Object Model classes
├── Tests/
│ ├── Features/ # Gherkin feature files
│ └── StepDefinitions/ # Step definition bindings
├── Screenshots/ # Runtime screenshots (auto-created)
├── allure-results/ # Allure result files (gitignored)
├── extent-report/ # Extent result files (gitignored)
├── SeleniumAutomation.csproj
├── .gitignore
└── README.md
```
---

## ✅ Existing Implementation

- SpecFlow Feature: `Login.feature`
- Step Definitions with assertions using NUnit
- Page Object Model with reusable locators and methods
- WebDriver management using `BaseTest.cs` and lifecycle via `Hooks.cs`
- Screenshot utility for test failures
- Gherkin-compliant scenario writing

---

## 🔍 SikuliX Integration Overview

### What is SikuliX?

**SikuliX** is a visual automation tool that uses image recognition to interact with UI elements that Selenium/WebDriver cannot locate (like non-HTML controls, canvas elements, or dynamic popups).

### Why Add SikuliX?

- Acts as **fallback automation** when locators break or UI becomes unidentifiable via DOM
- Enables **self-healing** by detecting elements via image if WebDriver fails
- Improves test stability for dynamic or canvas-based applications

---

## 🆕 What’s Added in This Extension?

- **`Base/VisualFallbackHelper.cs`**: A helper class to invoke SikuliX automation when DOM locators are not available.
- SikuliX .jar support to be invoked via C# using `ProcessStartInfo` or integration logic.
- Documentation and `.gitignore` updated for `.sikuli` and related temp files.

---

## 🔜 Future Enhancements

- Add fallback-to-image mechanism inside PageObject methods.
- Integrate more Sikuli-based flows with graceful error handling.
- Add sample `.sikuli` scripts in `/VisualAssets/`.

---

## 📝 SikuliX Setup (Prep)

- Java must be installed and available in PATH
- SikuliX jar (`sikulixide-<version>.jar`) must be downloaded and executable
- Image assets to be stored in a dedicated directory (`/SikuliAssets/`)

---

## 🔁 Repo Modifications for SikuliX Integration

| File                         | Purpose                                 |
|------------------------------|------------------------------------------|
| `Base/VisualFallbackHelper.cs` | New class for handling visual automation |
| `.gitignore`                | Updated to ignore screenshots, logs, and `.sikuli` temp |
| `README.md`                 | Documented integration steps and setup   |
| `SeleniumAutomation.csproj` | No new NuGet package yet for SikuliX; invoked via CLI |

---

## ▶️ How to Run

```bash
dotnet build
dotnet test
```
