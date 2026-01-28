## 📘 Lecture 8 — **Performance & Caching in Scalable Systems**

---

## 1️⃣ Why Performance Matters

Scalable systems must also be **fast**.

* Systems operate under **SLAs (Service Level Agreements)**
* Typical expectation:

  * Responses in **milliseconds**
  * Almost all the time (p99 / p99.9 latency)

📌 Scalability without performance = bad user experience.

---

## 2️⃣ The Main Enemies of Speed 🐢

Two things slow systems down the most:

1. **Disk access**

   * Slow compared to memory
2. **Network calls**

   * Especially cross–data center or internet requests

👉 Caching exists to **avoid both**.

![Image](https://cdn.thenewstack.io/media/2025/06/d2374f55-image1.png)

![Image](https://www.boldgrid.com/wp-content/uploads/2024/07/disk-caching-vs-memory-caching.jpg?x42587=)

---

## 3️⃣ What Is Caching?

Caching means:

* Store **frequently used data** in a faster location
* Usually **in memory**
* Avoid recomputing or re-fetching data

📌 Memory access ≫ Disk ≫ Network

---

## 4️⃣ Common Places to Cache

### 🔹 Client-Side Caching

* Browser cache
* Mobile app cache
* CDN edge cache

✔ Reduces server load
✔ Fastest possible response

---

### 🔹 Application-Level Cache

* In-memory cache in app servers
* Distributed cache shared by servers

Examples:

* **Redis**
* **Memcached**

![Image](https://substackcdn.com/image/fetch/%24s_%21lZd6%21%2Cf_auto%2Cq_auto%3Agood%2Cfl_progressive%3Asteep/https%3A%2F%2Fsubstack-post-media.s3.amazonaws.com%2Fpublic%2Fimages%2F903484b2-8c0c-4ce9-b4ab-e967538aeb78_1972x1197.jpeg)

![Image](https://www.researchgate.net/publication/3480194/figure/fig2/AS%3A341371471843329%401458400709247/Block-diagram-of-the-split-control-cache-Flow-based-and-application-relevant-data-are.png)

---

### 🔹 Database Query Cache

* Cache query results
* Avoid repeated expensive queries

📌 Useful for:

* Read-heavy workloads
* Analytics dashboards

---

## 5️⃣ Cache Placement Strategy

Good rule of thumb:

> **Cache as close to the user as possible**

Hierarchy:

1. CDN / Client cache
2. Application cache
3. Database
4. Disk

![Image](https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Nehalem_EP.png/500px-Nehalem_EP.png)

![Image](https://www.researchgate.net/publication/362028071/figure/fig2/AS%3A1180622391382020%401658493721810/The-proposed-multi-level-caching-architecture-Each-process-has-its-own-singleton-program.png)

---

## 6️⃣ Cache Invalidation (Hardest Problem 😅)

Caching is easy.
**Keeping cached data correct is hard.**

### Common Strategies:

* **TTL (Time to Live)**
* **Write-through cache**
* **Write-back cache**
* **Explicit invalidation**

📌 Trade-off:

* Freshness vs performance

---

## 7️⃣ When Caching Helps Most

* Hot data (frequently accessed)
* Read-heavy systems
* Expensive computations
* Remote service calls

❌ Less useful for:

* Highly dynamic data
* Write-heavy workloads

---

## 8️⃣ Caching in System Design Interviews

What interviewers want to hear:

* You know **where** to cache
* You understand **why**
* You can explain **trade-offs**

📌 Sample interview line:

> “To meet latency SLAs, I’d introduce a distributed in-memory cache to avoid database and network round trips for hot data.”

---

## 🔑 Key Takeaways

* SLAs demand millisecond responses
* Disk and network are slow
* Caching improves both **speed & scalability**
* Use multi-level caching
* Cache invalidation must be handled carefully
* Mention Redis/Memcached confidently in interviews

---

If you want next:

* 🧠 **Caching strategies deep dive**
* 🎯 **Interview-ready cache examples**
* 📄 **Markdown notes for all lectures**
* ▶️ **Lecture 9 notes**

Just say 👍
