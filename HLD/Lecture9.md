## 📘 Lecture 9 — **Caching Strategies in Large-Scale Systems**

---

## 1️⃣ Why Caching Is Essential

Any **high-performance, highly scalable system** will almost always use caching.

* Disk I/O is **slow & expensive**
* Databases have limited disk throughput
* Direct DB hits from many app servers → **bottleneck**

📌 Goal: **Avoid disk hits as much as possible**

---

## 2️⃣ Baseline: No Cache Architecture (Problematic)

### Flow

* Clients → Internet → Load Balancer
* Load Balancer → App Servers
* App Servers → **Single database**

![Image](https://media.geeksforgeeks.org/wp-content/cdn-uploads/20210204220403/Web-Application-Architecture.png)

![Image](https://substackcdn.com/image/fetch/%24s_%21g3db%21%2Cf_auto%2Cq_auto%3Agood%2Cfl_progressive%3Asteep/https%3A%2F%2Fsubstack-post-media.s3.amazonaws.com%2Fpublic%2Fimages%2F4a38175b-11e8-40ae-879c-ab3ce2027089_2008x1252.png)

### Problem

* All reads hit disk
* Database becomes the choke point
* Scaling app servers doesn’t help much

---

## 3️⃣ Adding a Caching Layer (Big Win)

### What Changes

* Introduce **in-memory cache** between app servers and DB
* Cache stores **frequently accessed data**

![Image](https://media.geeksforgeeks.org/wp-content/uploads/20240110183740/Cache-Working.jpg)

![Image](https://substackcdn.com/image/fetch/%24s_%211-x1%21%2Cf_auto%2Cq_auto%3Agood%2Cfl_progressive%3Asteep/https%3A%2F%2Fsubstack-post-media.s3.amazonaws.com%2Fpublic%2Fimages%2F8e2bfab1-465f-4120-9f49-a4395781beb3_1600x1040.png)

### Benefits

* Memory ≫ Disk speed
* Fewer DB hits
* Much lower latency
* Cache fleet can be **scaled independently**

---

## 4️⃣ Where Does the Cache Live?

### Option 1: In-Process Cache

* Cache inside each app server
* Simple, but:

  * Data duplicated
  * Harder to scale efficiently

### Option 2: Dedicated Cache Fleet (Preferred)

* Separate cache servers
* App servers talk to cache servers

Common tools:

* **Redis**
* **Memcached**

---

## 5️⃣ How Distributed Caches Work

* App server hashes a key
* Hash → specific cache server
* Each cache server owns a **subset of data**

📌 Same idea as **sharding**, but in memory.

---

## 6️⃣ When Caching Helps Most

Caching is best when:

* **Reads ≫ Writes**
* Data is reused frequently
* DB queries are expensive

❌ Less useful when:

* Write-heavy workloads
* Constantly changing data

---

## 7️⃣ Cache Expiration & Invalidation

Critical design question:

> **How long can data stay cached?**

### Too Long

* Data becomes stale
* Incorrect results

### Too Short

* Cache ineffective
* DB still overloaded

Common strategies:

* TTL (time-based expiry)
* Write-through / write-around
* Explicit invalidation on writes

📌 Always ask interviewers about **staleness tolerance**.

---

## 8️⃣ Hotspots (Celebrity Problem)

Some keys get **far more traffic** than others.

Example:

* IMDb actor pages
* “Brad Pitt” vs obscure actor

![Image](https://miro.medium.com/v2/resize%3Afit%3A1200/1%2AiYMHqMxq2AmuoB_ViNruuw.png)

![Image](https://media2.dev.to/dynamic/image/width%3D1080%2Cheight%3D1080%2Cfit%3Dcover%2Cgravity%3Dauto%2Cformat%3Dauto/https%3A%2F%2Fdev-to-uploads.s3.amazonaws.com%2Fuploads%2Farticles%2Foe50ymkjdpaxncll1wvg.png)

### Problems

* One cache server overloaded
* Uneven load distribution

### Solutions

* Replicate hot keys
* Smarter routing
* Dynamic rebalancing

---

## 9️⃣ Cold-Start Problem (Very Real 🔥)

What happens when:

* Cache layer restarts
* Cache is **empty**

Result:

* All traffic hits DB
* DB can crash under sudden load

📌 This happens in real systems.

---

## 🔟 Cold-Start Mitigation Strategies

* **Cache warm-up**

  * Replay yesterday’s traffic
  * Preload hot keys
* Don’t expose cache to traffic until primed
* Gradual traffic ramp-up

---

## 🔑 Final Takeaways

* Caching avoids slow disk access
* Distributed in-memory caches scale well
* Best for read-heavy systems
* Always consider:

  * Expiration policy
  * Hotspots
  * Cold-start behavior
* Mention Redis/Memcached confidently in interviews

---

If you want:

* 🧠 **Caching patterns cheat sheet**
* 🎯 **Interview-ready cache design answers**
* 📄 **Complete notes (Lectures 1–9) in markdown**
* ▶️ **Lecture 10 notes**

Just say 👍
