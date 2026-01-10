# Unity Player Controller

**One solid, reusable Player Controller for Unity (2D & 3D)**
Movement • Camera • Input System • Animation Hooks

Created and maintained by **[UnityKing.com](https://unityking.com)**

---

## ✨ Overview

This repository provides a **modular, reusable Player Controller** designed to work in both **2D and 3D Unity projects**.
It is built with flexibility in mind, making it easy to drop into new projects, extend, or customize for different game genres.

Whether you're prototyping quickly or building a full game, this controller gives you a strong foundation.

---

## 🔧 Features

* ✅ **2D & 3D Support**
* 🎮 **Unity Input System** (new Input System)
* 🏃 **Player Movement**

  * Walk / Run
  * Jump (optional)
  * Physics-based or transform-based
* 🎥 **Camera Controller**

  * Smooth follow
  * Mouse / stick look (3D)
  * Optional camera rotation limits
* 🎬 **Animation Hooks**

  * Animator-ready parameters
  * Easy integration with Mecanim
* 🧩 **Modular & Reusable**

  * Clean, readable code
  * Easy to extend or disable features
* 🧠 **Beginner-friendly, Production-ready**

---

## 📦 Requirements

* **Unity 2021 LTS or newer** (recommended)
* **Input System package** enabled
  (`Edit → Project Settings → Player → Active Input Handling` → *Input System Package*)

---

## 🚀 Getting Started

1. **Clone or download** this repository:

   ```bash
   git clone https://github.com/UnityKing/Unity-Player-Controller---Unity-King.git
   ```

2. Open the project in Unity.

3. Import or copy the `PlayerController` scripts into your own project if needed.

4. Add the **Player Controller** component to your player GameObject.

5. Assign:

   * Camera reference
   * Input Actions
   * Rigidbody / Character Controller (depending on mode)
   * Animator (optional)

6. Press ▶ **Play**

---

## 🎮 Input System

The controller is built using Unity’s **new Input System**.

Typical bindings include:

* Move (WASD / Left Stick)
* Look (Mouse / Right Stick)
* Jump
* Sprint

You can easily remap inputs via the Input Actions asset.

---

## 🎬 Animation Integration

Animation is **optional but supported**.

The controller exposes common parameters such as:

* Speed
* IsMoving
* IsGrounded
* Jump trigger

Simply connect them to your Animator Controller.

---

## 🧩 Customization

This controller is designed to be:

* Extended (add crouch, dash, climb, etc.)
* Stripped down (disable unused features)
* Adapted for:

  * Platformers
  * FPS / TPS
  * Top-down games

---

## 📁 Project Structure (Example)

```
Assets/
 ├── Scripts/
 │    ├── Player/
 │    │    ├── PlayerController.cs
 │    │    ├── PlayerMovement.cs
 │    │    ├── PlayerCamera.cs
 │    │    └── PlayerInputHandler.cs
 ├── Input/
 │    └── PlayerInputActions.inputactions
 └── Animations/
```

---

## 📜 License

This project is released under the **MIT License**.
You are free to use it in personal and commercial projects.

---

## 🌐 About the Author

**UnityKing.com**
Tutorials, tools, and systems for Unity developers.

* Website: [https://unityking.com](https://unityking.com)
* YouTube: *Unity King*
* GitHub: **UnityKing**

---

## ⭐ Support

If you find this project useful:

* ⭐ Star the repo
* 🐛 Open an issue for bugs
* 💡 Submit feature requests or pull requests

Happy developing! 🚀
