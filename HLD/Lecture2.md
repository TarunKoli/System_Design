## 📘 Lecture 2 — **Scalability: From Single Server to Horizontal Scaling**

---

## 1️⃣ The Core Question of Scalability

**How do you design systems that can handle millions of users at once?**

In real-world Big Tech systems:

* Servers may handle **tens of thousands of requests per second**
* Traffic spikes are normal (sales, viral events, crawlers, etc.)

Modern systems solve this using **scaling techniques**.

---

## 2️⃣ Single-Server Design (Does NOT Scale)

### 🔹 Architecture

* Many clients (phones, laptops, PCs)
* Requests go through the **internet**
* All traffic hits **one server**

  * Web server (HTTP)
  * Database (often on the same machine)

![Image](https://media.geeksforgeeks.org/wp-content/uploads/20231030151130/single-server-arch-web-server.webp)

![Image](https://assets.digitalocean.com/articles/architecture/u-single_server.png)

### 🔹 When Is This Okay?

* Personal websites
* Hobby projects
* Internal tools with very low traffic
* When downtime is acceptable

### 🔹 Problems

* ❌ **Single Point of Failure**
* If the server crashes:

  * Website goes down
  * Restore from backup
  * Update DNS
* ❌ Cannot handle high traffic
* ❌ Not suitable for commercial systems

👉 **Almost never acceptable in system design interviews**

---

## 3️⃣ Separating Web Server and Database (Small Improvement)

### 🔹 Architecture

* One **HTTP/Web server**
* One **Database server**
* They run on **separate machines**

![Image](https://assets.digitalocean.com/articles/architecture/u-separate_database.png)

![Image](https://media.geeksforgeeks.org/wp-content/uploads/20240907155154/2.png)

### 🔹 Benefits

* Web and DB can be **scaled independently**
* Better resource utilization
* More control over performance

### 🔹 Limitations

* Still ❌ **single point of failure**
* If DB goes down → site goes down
* If Web server goes down → site goes down

👉 Better than one server, but **still not resilient**

---

## 4️⃣ Vertical Scaling (Scaling *Up*)

### 🔹 What Is Vertical Scaling?

* Add **more power to the same server**

  * More CPU
  * More RAM
  * Faster storage
* Example: Upgrade to a bigger VM or physical machine

![Image](https://d138zd1ktt9iqe.cloudfront.net/media/seo_landing_files/mohit-uniyal-vertical-scaling-04-1609254123.png)

![Image](https://www.eginnovations.com/blog/wp-content/uploads/2024/07/diagram-02.webp)

### 🔹 Pros

* Simple to implement
* Fewer servers to maintain
* Works for:

  * Small systems
  * Temporary traffic spikes

### 🔹 Cons

* ❌ Hardware limits (CPU, memory caps)
* ❌ Very expensive at scale
* ❌ Still single point of failure
* ❌ Eventually hits a hard limit

👉 **Vertical scaling has a ceiling**

---

## 5️⃣ Horizontal Scaling (Scaling *Out*) ✅

### 🔹 What Is Horizontal Scaling?

* Add **more servers**, not bigger ones
* Use a **load balancer** to distribute traffic

![Image](https://www.researchgate.net/publication/228929504/figure/fig2/AS%3A300885512081409%401448748104249/How-load-balancing-works-in-horizontal-scalability.png)

![Image](https://severalnines.com/sites/default/files/blog/node_6056/image1.png)

### 🔹 Architecture

* Clients → Internet
* Load Balancer
* Multiple Web Servers
* (Optional) Shared Database / Cache

### 🔹 Why This Is Powerful

* ✅ No single point of failure
* ✅ If one server dies, traffic is rerouted
* ✅ Add servers as traffic grows
* ✅ Near-infinite scalability

👉 **This is what Big Tech uses**

---

## 6️⃣ Load Balancer (High-Level)

A load balancer:

* Distributes incoming requests across servers
* Can use strategies like:

  * Round-robin
  * Capacity-aware routing
* Automatically avoids failed servers

Users **never notice failures** if capacity is sufficient.

---

## 7️⃣ Stateless vs Stateful Servers (Very Important)

### 🔹 Stateless Servers (Required for Horizontal Scaling)

* Servers **do not store user session data locally**
* Any server can handle any request
* State is stored in:

  * Database
  * Cache (Redis, Memcached, etc.)

### 🔹 Why Stateless Is Necessary

* Load balancer may send requests to **different servers**
* Server cannot assume it handled previous requests

📌 **Rule**:

> Horizontal scaling only works well with **stateless web servers**

---

## 8️⃣ Choosing the Right Architecture

### 🔹 Design Principle: **Simplicity**

> Choose the **simplest architecture** that meets requirements — but no simpler.

* Small internal tool → simple / vertical scaling
* Massive public system → horizontal scaling

### 🔹 In System Design Interviews

* You’re usually asked to design:

  * YouTube
  * Google
  * Large-scale platforms
* ✅ Horizontal scaling is the expected answer

---

## 9️⃣ Final Comparison (Quick Revision)

| Scaling Type       | Meaning                   | Pros                     | Cons                           |
| ------------------ | ------------------------- | ------------------------ | ------------------------------ |
| Single Server      | Everything on one machine | Simple                   | No scalability, no reliability |
| Vertical Scaling   | Bigger machine            | Easy to implement        | Hard limit, expensive          |
| Horizontal Scaling | More machines             | Scalable, fault-tolerant | More complexity                |

---

## 🔑 Key Takeaways

* **Vertical scaling** = bigger machines (limited)
* **Horizontal scaling** = more machines (preferred)
* Load balancers distribute traffic
* Stateless servers are essential
* Horizontal scaling enables **massive, reliable systems**

---

If you want next:

* 🔍 **Interview-ready condensed notes**
* 🧠 **Real-world examples (Amazon, Netflix style)**
* 📄 **Markdown version**
* ▶️ **Lecture 3 notes**

Just tell me 👍
