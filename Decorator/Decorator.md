# Decorator Design Pattern – Complete & Detailed Explanation (C#)

---

## 📌 Overview

The **Decorator Design Pattern** is a **Structural Design Pattern** that allows behavior to be added to objects dynamically without modifying their structure.

---

## ❓ Why the Decorator Pattern Exists

### 🔴 The Problem

Subclassing to add features leads to:
- Class explosion
- Rigid designs
- Difficult maintenance

---

## ✅ What the Decorator Pattern Solves

Decorator:
- Adds behavior dynamically
- Avoids subclass explosion
- Follows Open/Closed Principle

---

## 🎯 Goal of the Decorator Pattern

To attach additional responsibilities to an object dynamically.

---

## 🧠 Core Idea

> **“Wrap an object to add new behavior.”**

---

## 🧩 Step-by-Step Explanation

### Step 1: Define a common component interface  
### Step 2: Create a concrete component  
### Step 3: Create an abstract decorator  
### Step 4: Implement concrete decorators  
### Step 5: Wrap objects at runtime  

---

## 🔁 Runtime Behavior Summary

- Client uses component interface
- Decorators wrap the component
- Each decorator adds behavior

---

## ⚖️ Pros and Cons

### ✅ Advantages
- Flexible behavior extension
- No modification of existing code
- Multiple decorators can be combined

### ❌ Disadvantages
- Harder to debug
- Many small classes

---

## 🎯 When to Use

- Adding optional features
- Runtime behavior changes
- Avoiding subclass explosion

---

## 🚫 When NOT to Use

- Simple feature additions
- Performance-critical paths

---

## 🏢 Real-World Use Cases

- Logging systems
- Notification systems
- UI component styling

---
