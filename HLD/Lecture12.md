## 📘 Lecture 12 — **Resilience & Fault Tolerance in Large-Scale Systems**

---

## 1️⃣ Why Resilience Is Critical

In Big Tech systems:

* **Downtime = huge financial loss**
* SLAs are strict
* Users expect systems to be **always available**

📌 Irony of scale:

> The more servers you have, the **more likely something fails every day**.

So failure is **normal**, not exceptional.

---

## 2️⃣ Types of Failures You Must Expect

A good system design assumes failures at **every level**:

* ❌ Single server crashes
* ❌ Process hangs / locks up
* ❌ Entire rack failure
* ❌ Data center outage
* ❌ Whole region goes down

📌 Interviewers want to see that you **design for failure**, not hope it won’t happen.

![Image](https://lethain.com/static/blog/2019/fault-domains-01.png)

![Image](https://www.7x24exchange.org/wp-content/uploads/2023/04/Spring-2023-Joerge-Gil-img-2.jpg)

---

## 3️⃣ Core Principle: Eliminate Single Points of Failure

Any component that can fail **must have a backup**.

Examples:

* Load balancers → multiple instances
* App servers → fleets
* Databases → replicas
* Routers → failover leaders

📌 If one component goes down, traffic should **automatically reroute**.

---

## 4️⃣ Redundancy at Multiple Levels

### 🔹 Server-Level Redundancy

* Multiple app servers
* Health checks
* Automatic replacement

### 🔹 Rack-Level Redundancy

* Don’t place all replicas on the same rack
* Power/network failure protection

### 🔹 Data Center / Zone Redundancy

* Deploy across **multiple availability zones**
* Zone failure should not take system down

![Image](https://learn.microsoft.com/en-us/azure/well-architected/design-guides/_images/regions-availability-zones/zonal-multiple-zones.png)

![Image](https://docs.aws.amazon.com/images/wellarchitected/2023-04-10/framework/images/multi-az-architecture.png)

---

## 5️⃣ Regional Resilience (Disaster Recovery)

For critical systems:

* Deploy in **multiple geographic regions**
* Traffic can fail over between regions

Scenarios handled:

* Natural disasters
* Massive network outages
* Cloud provider incidents

![Image](https://d2908q01vomqb2.cloudfront.net/fc074d501302eb2b93e2554793fcaf50b3bf7291/2021/07/21/Figure-2.-DR-implementation-architecture-on-multi-Region-active-passive-workloads.png)

![Image](https://d2908q01vomqb2.cloudfront.net/fc074d501302eb2b93e2554793fcaf50b3bf7291/2021/05/13/Figure-2.-Pilot-light-DR-strategy.png)

📌 This is how systems survive **continent-scale failures**.

---

## 6️⃣ Graceful Degradation

Not everything has to work perfectly during failures.

Examples:

* Serve cached data if DB is down
* Disable non-critical features
* Show read-only mode

📌 Better to be **partially available** than completely down.

---

## 7️⃣ Timeouts, Retries & Circuit Breakers

Resilient systems:

* Use **timeouts** (never wait forever)
* Retry failed requests (with limits)
* Use **circuit breakers** to stop cascading failures

📌 Prevents one failure from bringing down the entire system.

---

## 8️⃣ Data Replication & Backups

To survive failures:

* Replicate data across nodes/zones/regions
* Regular backups
* Automated restore processes

📌 Backups are useless unless **tested**.

---

## 9️⃣ Monitoring & Fast Recovery

You can’t fix what you can’t see.

Key practices:

* Health checks
* Alerts
* Auto-scaling
* Auto-replacement of failed nodes

📌 Mean Time To Recovery (MTTR) matters more than avoiding failures.

---

## 🔑 What Interviewers Are Looking For

They want to hear:

* “Failures are expected”
* “No single point of failure”
* “Multi-zone / multi-region”
* “Automatic failover”
* “Graceful degradation”

📌 Using these phrases signals **senior system design thinking**.

---

## 🧠 Final Takeaways

* Failures are inevitable at scale
* Design systems to **expect and survive failures**
* Redundancy at every layer
* Multi-zone & multi-region deployments
* Graceful degradation beats total outage
* Resilience is a **core system design skill**

---

If you want:

* 🧠 **Failure-handling cheat sheet**
* 🎯 **Interview answers for fault tolerance**
* 📄 **All lectures (1–12) combined notes**
* ▶️ **Next lecture notes**

Just tell me 👍
