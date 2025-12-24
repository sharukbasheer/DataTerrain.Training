# Proxy Design Pattern – Complete & Detailed Explanation (C#)

---

## 📌 Overview

The **Proxy Design Pattern** is a **Structural Design Pattern** that provides a **placeholder or surrogate** for another object to control access to it.

The proxy represents the real object and intercepts requests before forwarding them.

---

## ❓ Why the Proxy Pattern Exists

### 🔴 The Problem

Direct access to certain objects may be:
- Expensive
- Unsafe
- Remote
- Restricted

Clients should not always interact with real objects directly.

---

## ✅ What the Proxy Pattern Solves

The Proxy pattern:
- Controls access to an object
- Adds additional behavior transparently
- Protects or manages expensive operations

---

## 🎯 Goal of the Proxy Pattern

To control access to an object while keeping the same interface.

---

## 🧠 Core Idea

> **“Control access to an object without changing its interface.”**

---

## 🧩 Step-by-Step Explanation of the Proxy Pattern

---

### 🔹 Step 1: Define a Common Interface

Both the proxy and the real object implement the same interface.

---

### 🔹 Step 2: Create the Real Subject

The real object:
- Contains the actual business logic
- May be expensive or sensitive

---

### 🔹 Step 3: Create the Proxy Class

The proxy:
- Holds a reference to the real object
- Controls access
- Adds extra behavior (lazy loading, logging, security)

---

### 🔹 Step 4: Delegate Calls to the Real Object

The proxy decides:
- Whether to forward the request
- When to create the real object
- How to manage access

---

### 🔹 Step 5: Use the Proxy in Client Code

The client:
- Uses the interface
- Is unaware whether it works with a proxy or real object

---

## 🔁 Runtime Behavior Summary

- Client calls proxy
- Proxy performs checks or setup
- Proxy forwards request to real object
- Result is returned

---

## ⚖️ Pros and Cons of the Proxy Pattern

### ✅ Advantages
- Controlled access
- Lazy initialization
- Additional behavior without modifying real object

### ❌ Disadvantages
- Increased complexity
- Additional indirection

---

## 🎯 When to Use the Proxy Pattern

Use Proxy when:
- Access control is required
- Objects are expensive to create
- Remote objects are involved

---

## 🚫 When NOT to Use the Proxy Pattern

Avoid Proxy when:
- Direct access is simple and safe
- Performance overhead is unacceptable

---

## 🏢 Real-World Use Cases

- Virtual proxies (lazy loading)
- Security proxies
- Remote service proxies
- Caching proxies

---
