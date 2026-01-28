## 📘 Lecture 10 — **Cache Eviction Policies & Caching Technologies**

---

## 1️⃣ Why Eviction Policies Matter

Caches have **finite memory**.
When they fill up, the system must decide **what to keep** and **what to evict**.

* If data **is in cache** → fast response
* If data **is not in cache** → **cache miss**

  * Request goes to database
  * Cache may be repopulated

📌 Eviction policy = rules for handling limited memory.

---

## 2️⃣ Most Common Eviction Policies

### 🔹 **LRU — Least Recently Used** (Most Common)

Evict the item **not accessed for the longest time**.

![Image](https://assets.bytebytego.com/diagrams/0059-top-8-cache-eviction-strategies.png)

![Image](https://i.sstatic.net/fiJIk.png)

**How it works (conceptually):**

* Recently accessed → move to front
* Least recently accessed → pushed to back
* Evict from the **tail**

**Typical implementation:**

* HashMap → O(1) key lookup
* Doubly Linked List → O(1) reorder

📌 Very common **interview question**: *Design an LRU cache*

---

### 🔹 **LFU — Least Frequently Used**

Evict the item with the **lowest access count**.

**Pros**

* Better prediction for small caches

**Cons**

* More complex
* Tracking frequency adds overhead

📌 Used when cache size is small & access patterns are skewed.

---

### 🔹 **FIFO — First In, First Out**

Evict the **oldest inserted** item.

**Pros**

* Very simple

**Cons**

* Ignores usage patterns
* Rarely ideal for real workloads

---

## 3️⃣ Choosing the Right Policy

| Policy | Best When                       |
| ------ | ------------------------------- |
| LRU    | General-purpose, large caches   |
| LFU    | Small cache, predictable access |
| FIFO   | Simplicity > efficiency         |

📌 **LRU works well most of the time**.

---

## 4️⃣ Popular Caching Technologies

### 🔹 **Memcached**

* Simple in-memory key–value store
* Extremely fast
* Minimal features
* Very stable & battle-tested

✔ Simple
✔ Reliable
❌ Limited functionality

---

### 🔹 **Redis** (Most Popular Today)

* In-memory store
* Supports:

  * Replication
  * Persistence (snapshots)
  * Transactions
  * Pub/Sub
  * Advanced data structures

![Image](https://substackcdn.com/image/fetch/%24s_%21OsiQ%21%2Cf_auto%2Cq_auto%3Agood%2Cfl_progressive%3Asteep/https%3A%2F%2Fsubstack-post-media.s3.amazonaws.com%2Fpublic%2Fimages%2F778a7e21-455b-45f6-8487-63f9eb41e88b_2000x1414.jpeg)

![Image](https://media.geeksforgeeks.org/wp-content/uploads/20230914185841/redis-publish-subscriber.png)

✔ Feature-rich
✔ Highly reliable
❌ More complex than Memcached

📌 Redis is often the **default choice** today.

---

## 5️⃣ Language / Platform-Specific Caches

* **NCache** → .NET-focused (also Java, Node.js)
* **Ehcache** → Java ecosystem

📌 Useful when tightly coupled to a specific stack.

---

## 6️⃣ Cloud-Managed Caching

### 🔹 **Amazon ElastiCache**

* Fully managed Redis or Memcached
* No server maintenance
* Runs in same AWS data centers as apps

![Image](https://d2908q01vomqb2.cloudfront.net/fc074d501302eb2b93e2554793fcaf50b3bf7291/2021/10/07/Heimdall-Proxy.png)

![Image](https://docs.aws.amazon.com/images/whitepapers/latest/scale-performance-elasticache/images/elasticache-for-redis.png)

✔ Managed
✔ Scales easily
✔ Low ops overhead

📌 Best if your stack already runs on **AWS**.

---

## 7️⃣ Interview-Worthy Takeaways 🧠

Say things like:

* “LRU is a good default eviction policy.”
* “Redis provides richer features like pub/sub and persistence.”
* “Managed caches like ElastiCache reduce operational overhead.”

---

## 🔑 Final Summary

* Cache size is limited → eviction is required
* **LRU** is the most common eviction strategy
* **LFU** is more precise but complex
* **FIFO** is simple but weak
* **Memcached** = simple & fast
* **Redis** = powerful & flexible
* **ElastiCache** = managed Redis/Memcached on AWS

---

If you want:

* 🧠 **LRU cache interview solution**
* 📄 **All lectures (1–10) combined notes**
* 🎯 **System design interview cache answers**
* ▶️ **Lecture 11 notes**

Just say 👍
