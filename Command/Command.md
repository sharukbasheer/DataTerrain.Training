# Command Design Pattern – Complete & Detailed Explanation (C#)

---

## 📌 Overview

The **Command Design Pattern** is a **Behavioral Design Pattern** that encapsulates a request as an object.

---

## ❓ Why the Command Pattern Exists

### 🔴 The Problem

Direct method calls lead to:
- Tight coupling
- No undo/redo support
- Hard-coded logic

---

## ✅ What the Command Pattern Solves

Command:
- Encapsulates requests
- Supports undo/redo
- Decouples sender and receiver

---

## 🎯 Goal of the Command Pattern

To parameterize clients with different requests.

---

## 🧠 Core Idea

> **“Encapsulate a request as an object.”**

---

## 🧩 Step-by-Step Explanation

1. Define command interface
2. Create concrete commands
3. Implement receiver
4. Create invoker
5. Execute commands dynamically

---

## 🔁 Runtime Behavior Summary

- Invoker triggers command
- Command calls receiver
- Receiver performs action

---

## ⚖️ Pros and Cons

### ✅ Advantages
- Decouples sender and receiver
- Enables undo/redo

### ❌ Disadvantages
- More classes introduced

---

## 🎯 When to Use

- Undo/redo operations
- Queued or logged commands

---

## 🚫 When NOT to Use

- Simple direct calls

---

## 🏢 Real-World Use Cases

- UI buttons
- Macro systems
- Transaction processing

---
