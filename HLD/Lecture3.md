## 📘 Lecture 3 — **Where Do Servers Come From & How Databases Scale**

---

## 1️⃣ Where Do Servers Physically Live?

When we talk about “adding more servers,” they must exist **somewhere physically**:

* Power ⚡
* Networking 🌐
* Cooling ❄️
* Security 🔐

### Two Main Options:

1. **Company-Owned Data Centers**
2. **Cloud Providers (most common today)**

---

## 2️⃣ Company-Owned Data Centers

Used by massive companies like **Amazon** or **Google**

### Pros

* Full control over hardware
* Can optimize for internal workloads

### Cons

* Limited space & budget
* Slow provisioning
* Operational overhead (Ops teams, capacity planning)

📌 Often, **getting servers approved** is harder than designing the system.

---

## 3️⃣ Cloud Computing (Most Common Approach)

### Example: **Amazon Web Services (AWS)**

* **EC2 (Elastic Compute Cloud)** → Rent virtual machines on demand
* Pay only for what you use
* Spin servers up/down instantly

![Image](https://www.researchgate.net/publication/331705531/figure/fig1/AS%3A11431281454011934%401747940628523/Cloud-computing-data-center-structure.png)

![Image](https://d2908q01vomqb2.cloudfront.net/fc074d501302eb2b93e2554793fcaf50b3bf7291/2023/05/10/Figure-1.-Solution-architecture-1024x547.png)

![Image](https://www.researchgate.net/publication/261279342/figure/fig1/AS%3A599640927907840%401519976946120/Scenarios-of-virtual-machine-images-distribution-in-cloud-hosting-centers.png)

### Benefits

* No hardware management
* Fast provisioning
* Cost control
* Maintenance handled by provider

⚠️ Servers **can still fail** → your architecture must handle failures.

---

## 4️⃣ Regions & Availability Zones

Cloud providers let you deploy servers across:

* Different **regions**
* Different **availability zones (AZs)**

### Why This Matters

* Fault tolerance
* Disaster recovery
* Can survive:

  * Data center failure
  * Regional outages (even continent-level failures)

📌 We’ll revisit this when discussing **global systems**.

---

## 5️⃣ Serverless Services (No Servers to Think About)

Some cloud services **hide servers completely**:

Examples (AWS):

* Lambda → run code snippets
* Kinesis → streaming data
* Athena → query data lakes

![Image](https://www.kofi-group.com/wp-content/uploads/2021/03/shutterstock_1609164064-scaled-1.jpg)

![Image](https://assets-global.website-files.com/6340354625974824cde2e195/65f0dd2ea5d885014b1a6840_GIF1.gif)

![Image](https://www.globaldots.com/images/2019/04/serverless-architecture-diagram.png)

### Key Idea

* You don’t manage servers
* You pay per request / usage
* Infrastructure is abstracted away

📌 Great for:

* Event-driven systems
* Rapid development
* Certain workloads (not all)

---

## 6️⃣ Database = Another Single Point of Failure

Even if web servers scale horizontally,
👉 **Database failure can still bring everything down**

So databases must also be **scaled and protected**.

---

## 7️⃣ Cold Standby Database ❄️

### How It Works

* Primary DB runs normally
* Periodic backups stored elsewhere
* Standby DB exists but is **empty or outdated**
* On failure:

  * Restore backup
  * Redirect traffic

![Image](https://media.geeksforgeeks.org/wp-content/uploads/20250613144558743032/cold_standby_.webp)

![Image](https://d2908q01vomqb2.cloudfront.net/fc074d501302eb2b93e2554793fcaf50b3bf7291/2021/04/23/Figure-2.-Backup-and-restore-DR-strategy-1247x630.png)

### Pros

* Cheap
* Simple

### Cons

* Long downtime (hours/days)
* Data loss since last backup
* Poor user experience

📌 Suitable only for **non-critical systems**

---

## 8️⃣ Warm Standby Database 🔥

### How It Works

* Primary DB + secondary DB
* **Replication enabled**
* Standby always has near-current data
* On failure:

  * Redirect traffic quickly

![Image](https://infocenter.sybase.com/help/topic/com.sybase.infocenter.dc32518.1550/html/rsadmin_vol_2/fig3-6wsa4pdb.gif)

![Image](https://assets.digitalocean.com/articles/architecture/u-primary_replica_database_replication.png)

### Pros

* Minimal downtime
* Very little data loss
* Easy to manage (replication built-in)

### Cons

* Still limited by **single primary DB**
* Backup DB usually idle

📌 Common in real production systems

---

## 9️⃣ Hot Standby Database 🔥🔥

### How It Works

* Real-time replication
* Standby DB is **live**
* Reads can be served from both DBs
* Writes go to primary

![Image](https://docs.oracle.com/cd/E29597_01/server.1111/e17157/img/haovw005.gif)

![Image](https://substackcdn.com/image/fetch/%24s_%21AdWX%21%2Cf_auto%2Cq_auto%3Agood%2Cfl_progressive%3Asteep/https%3A%2F%2Fbucketeer-e05bbc84-baa3-437e-9518-adb32be77984.s3.amazonaws.com%2Fpublic%2Fimages%2F310babaa-4a78-47ec-a925-125ab9b19a71_1536x1572.png)

### Pros

* Near-zero downtime
* Better read scalability
* Very high availability

### Cons

* More complexity
* Still not full horizontal write scaling

---

## 🔟 Multi-Primary (Multi-Master) Database ⚡

### How It Works

* Multiple DBs
* Reads & writes on all nodes
* No single primary

### Pros

* High availability
* Moves closer to true horizontal scaling
* Can survive DB node failures

### Cons

* Complex conflict resolution
* Harder recovery & consistency management

📌 Used only when absolutely necessary

---

## 🧠 Big Picture Summary

| Approach      | Downtime | Data Loss      | Complexity | Cost   |
| ------------- | -------- | -------------- | ---------- | ------ |
| Cold Standby  | High     | High           | Low        | Low    |
| Warm Standby  | Low      | Low            | Medium     | Medium |
| Hot Standby   | Very Low | Near-zero      | High       | High   |
| Multi-Primary | Minimal  | None (ideally) | Very High  | High   |

---

## 🔑 Key Takeaways

* Servers live in **data centers or the cloud**
* Cloud makes horizontal scaling practical
* Serverless hides infrastructure entirely
* Databases need **redundancy**
* Cold → Warm → Hot → Multi-primary = increasing availability & complexity
* Interviews usually expect **warm/hot standby or beyond**

---

If you want next:

* ▶️ **Lecture 4 notes**
* 📄 **Markdown version**
* 🧠 **Interview cheat-sheet**
* 🔍 **Real-world examples (AWS / Netflix-style)**
