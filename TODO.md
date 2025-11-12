Description: Write DateTime when done a task.

# 7/11/2025

## Network Capture

- **FEATURE** [x] Make a WinForms that show all the description of the network device selected. ***(07/11/2025)***
    - [x] Know what all the device attributes you can show to the client (ip addr, mac addr, name, ...). 
    - [x] Display to a Winform 
    - [x] Need an icon for network device to display WinForm
- **FEATURE** [x] Capture network packet in selected device. ***(10/11/2025)***
    - [x] Design so that it can start/stop capture packets. 
    - [x] List all packets in a data grid.
- **FEATURE** [x] Make a graph that shows statistics network (like a network speedtest that shows Download/Upload speed (Mbps)) ***(10/11/2025)***
    - [x] Download/Upload statistics.
    - [x] Display to a graph.

## Firewall
- **FEATURE** [ ] Firewall integrated.

# 10/11/2025
- **FEATURE** [ ] List all application that using network and their download/upload speed when hover the speed graph.

# 11/11/2025
## Network Capture
- **BUG** [x] Right now, the download speed and upload speed is calculated by average packets in the capturing time. **Expect**: calculated by number of Mb in each second. ***11/11/2025***
- **BUG** [x] When doing internet speed test, the graph does not update =>  **Optimize** ***11/11/2025***
- **FEATURE** [ ] There will be another screen shows all detail list of packets (including data of that packets). Ref: Wireshark.

# 12/11/2025
- **FEATURE** [ ] Save to pcap file after done capturing.

# FINAL RELEASE
- [ ] Make an installer for windows.