package HackSystem;

/**
 * 导入包
 */

import com.sun.management.OperatingSystemMXBean;
import java.io.File;
import java.lang.management.ManagementFactory;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Scanner;

public class MainSystem {
	Servers myservers = new Servers("your servers", "202.193.80.3", "root", "king", "", true, true, true, false);
	HackPic hackPic = new HackPic();
	Scanner scan = new Scanner(System.in);
	@SuppressWarnings("restriction")
	OperatingSystemMXBean mem = (OperatingSystemMXBean) ManagementFactory
			.getOperatingSystemMXBean();
	Viruses viruses = new Viruses();
	List<Servers> serverlist = null;
	RandomIP randomIP = new RandomIP();
	DiraySystem diraySystem = new DiraySystem();
	Servers tempservers = null;
	HackFileTools fileTools = new HackFileTools();

	Servers King_server = new Servers("king's server", randomIP.getRandomIP(), "king", "falldown", "", true, true,
			true, false);

	public void start() {
		serverlist = fileTools.Load();
		if (serverlist == null) {
			

			Firstin();

			serverlist = new ArrayList<Servers>();
			serverlist.add(myservers);
			serverlist.add(King_server);
			fileTools.Save(serverlist);
			serverlist = fileTools.Load();
		}

		
		while (true) {
			Scanner scan = new Scanner(System.in);
			
			System.out.println("admin: ");
			String admin = scan.next();
			System.out.println("password:");
			String password = scan.next();
			if (admin.equals("root") && password.equals("king")) {
				System.out.println(admin + " ");
				tempservers = myservers;
				break;
			}
			System.out.println("TIP: admin: root password: king");
		}

		
		while (true) {
			Scanner scan = new Scanner(System.in);
			System.out.print("$ " + tempservers.getIP() + ">: ");			String con = scan.next();
			SetConfig(con);

		}
	}

	public void SetConfig(String str) {
	


		Scanner scanner = new Scanner(System.in);

		if (str.equals("ver")) {
			
			System.out.println("系统版本：HackSystem OS 1.0 Beat\n内核版本: HackCore 9970K");
		} else if (str.equals("time")) {
			
			SimpleDateFormat df = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
			System.out.println(df.format(new Date()));
		} else if (str.equals("connect")) {
						System.out.println("请输入要链接的IP地址");
			String ipad = scan.next();
			int i = 0;
			for (Servers servers : serverlist) {
				if (serverlist.get(i).getIP().equals(ipad)) {
					tempservers = serverlist.get(i);
				}
				i++;
			}

		} else if (str.equals("scan")) {
			
			System.out.println("目标主机端口：");
			tempservers.showserverAttatc();
		} else if (str.equals("EXIT")) {
			
			System.out.println("系统退出......");
			System.exit(0);
		} else if (str.equals("disklist")) {
			
			File[] roots = File.listRoots();
			System.out.println("================================================================================");
			for (File _file : roots) {
				System.out.println(_file.getPath());
				System.out.println("空间未使用 : " + _file.getFreeSpace() / 1024 / 1024 + "M" + "   已经使用的空间 : "
						+ _file.getUsableSpace() / 1024 / 1024 + "M" + "  总容量 : " + _file.getTotalSpace() / 1024 / 1024
						+ "M");
			}
			System.out.println("================================================================================");
		} else if (str.equals("raminfo")) {
			// raminfo指令获取内存使用情况
			System.out.println("内存总量 ： " + mem.getTotalPhysicalMemorySize() / 1024 / 1024 + "M");
			System.out.println("可用内存 ： " + mem.getFreePhysicalMemorySize() / 1024 / 1024 + "M");
		} else if (str.equals("defender")) {
			// 调用防火墙程序（只是个动画）
			hackPic.definer();

		} else if (str.equals("gameinfo")) {
			// 显示游戏信息，提示用户赢得游戏的方法（需要用户自己发掘）
			System.out.println("  这是个需要用户自己发掘的游戏，找到关键信息，输入关键的密码，解开游戏的谜题\n"
					+ "在每台电脑的邮箱中找到不同的信息，那是有关于已经隐退的黑客 king 的信息(或许\n" + "是king留下的？)。 king 隐藏自己的背后究竟有什么真像，帮助 king 重见天日或者\n"
					+ "暗中帮助 king 完成他的使命......" + "  值得注意的是，你每次重新启动游戏时，所有除你之外的主机的IP地址都会发生变\n" + "化,祝你好运......");
		} else if (str.equals("diray")) {
			// 调用日记程序
			diraySystem.star();
		} else if (str.equals("submit")) {

			// 提交结局的代码，根据用户舒服的结局代码不同，得到不同的结局

			System.out.println("请输入得到的密码(这会直接影响结局) ：");
			if (scan.next().equals("")) {
				System.out.println("");
			}

		} else if (str.equals("save")) {
			// 存档
			fileTools.Save(serverlist);
		} else if (str.equals("listener")) {
			// 监听器，获取程序当前的某些信息和用户设备上的信息
			System.out.println("虚拟机可以使用的总内存：" + Runtime.getRuntime().maxMemory() / 1024 / 1024 + "M");
			System.out.println("允许分配给该程序使用的内存：" + mem.getCommittedVirtualMemorySize() / 1024 / 1024 + "M");
			System.out.println("用户的本地操作系统名称：" + mem.getName());
			System.out.println("用户的系统版本信息：" + mem.getVersion());
			System.out.println("用户的本地操作系统架构：" + mem.getArch());
			System.out.println("用户当前设备处理器数量：" + mem.getAvailableProcessors());
			System.out.println("处理器运行该程序花费的时间：" + (mem.getProcessCpuTime() / 1000000) + " MS");
			// 方法等同于System.out.println(Runtime.getRuntime().availableProcessors());
			System.out.println("最后一分钟的系统负载平均值：" + mem.getSystemLoadAverage());

		} else if (str.equals("prohack")) {
			// 攻击目标IP
			viruses.ProHacked(tempservers);
			int i = 0;
			for (Servers servers : serverlist) {
				if (tempservers.getIP().equals(serverlist.get(i).getIP())) {
					serverlist.set(i, tempservers);
				}
			}
		} else if (str.equals("HTTPatc")) {
			// 攻击HTTP端口
			viruses.HTTPatc(tempservers);
			int i = 0;
			for (Servers servers : serverlist) {
				if (tempservers.getIP().equals(serverlist.get(i).getIP())) {
					serverlist.set(i, tempservers);
				}
			}
		} else if (str.equals("FTPatc")) {
			// 攻击FTP端口
			viruses.FTPatc(tempservers);
			int i = 0;
			for (Servers servers : serverlist) {
				if (tempservers.getIP().equals(serverlist.get(i).getIP())) {
					serverlist.set(i, tempservers);
				}
			}
		} else if (str.equals("SSHatc")) {
			// SSH的攻击方式
			viruses.SSHatc(tempservers);
			int i = 0;
			for (Servers servers : serverlist) {
				if (tempservers.getIP().equals(serverlist.get(i).getIP())) {
					serverlist.set(i, tempservers);
				}
			}
		} else if (str.equals("link")) {
			// 显示所有已知IP地址。打印serverlist里所有主机的信息
			int i = 0;
			for (Servers servers : serverlist) {
				serverlist.get(i).showserverinfo();
				i++;
			}
		} else if (str.equals("dc")) {
			// 断开与目标主机的链接，回到自己主机的方法
			int i = 0;
			for (Servers servers : serverlist) {
				if (tempservers.getIP().equals(serverlist.get(i).getIP())) {
					serverlist.set(i, tempservers);
				}
			}
			tempservers = myservers;
		} else if (str.equals("help")) {
			System.out.println("===============================================================");
			System.out.println("|  ver : 显示系统版本和信息");
			System.out.println("|  listener : 查看程序的资源占用情况和用户设备上的某些信息");
			System.out.println("|  time : 获取系统当前时间");
			System.out.println("|  connect : 链接其他计算机的IP，但是需要正确的IP地址");
			System.out.println("|  scan : 扫描当前主机的端口情况");
			System.out.println("|  disklist : 获取当前设备的硬盘使用情况");
			System.out.println("|  raminfo : 获取当前设备的内存使用情况");
			System.out.println("|  defender : 使用防火墙隔离其他IP的恶意操作");
			System.out.println("|  diray : 打开日记管理");
			System.out.println("|  gameinfo : 获得游戏提示以及赢得游戏的方法");
			System.out.println("|  xxxxxx : 游戏的隐藏指令。提交得到结局的关键代码，需要用户搜集信息");
			System.out.println("|  prohack : 骇入目标IP");
			System.out.println("|  HTTPatc ： 攻击HTTP端口");
			System.out.println("|  FTPatc ：攻击FTP端口");
			System.out.println("|  SSHatc ：攻击防火墙");
			System.out.println("|  link : 检查和显示所有已知的IP地址");
			System.out.println("|  dc : 断开与目标主机的链接，回到自己的主机");
			System.out.println("|  ");
			System.out.println("|  save : 存档，保存当前用户的信息和进度");
			System.out.println("|  EXIT : 退出系统(注意大小写)");
			System.out.println("===============================================================");
		}

		else {
			System.out.println("指令： " + str + " 是无效指令，如需帮助，请使用 help指令");
		}

	}
	public void Firstin() {
		System.out.println("第一次进入......");
	}

}
