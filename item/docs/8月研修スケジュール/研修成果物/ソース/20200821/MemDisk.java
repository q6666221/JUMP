
import java.io.File;
import java.lang.management.ManagementFactory;
import com.sun.management.OperatingSystemMXBean;

public class MemDisk {
    public static void main(String[] args)
    {

        getMemInfo();

        System.out.println();

        getDiskInfo();

    }
    public static void getDiskInfo()    {
        File[] disks = File.listRoots();
        for(File file : disks)        {
            System.out.print(file.getPath() + "    ");
            System.out.print(" = " + file.getFreeSpace() / 1024 / 1024 + "M" + "    ");
            System.out.print(" = " + file.getUsableSpace() / 1024 / 1024 + "M" + "    ");
            System.out.print(" = " + file.getTotalSpace() / 1024 / 1024 + "M" + "    ");
            System.out.println();
        }
    }

    public static void getMemInfo()    {
        OperatingSystemMXBean mem = (OperatingSystemMXBean) ManagementFactory.getOperatingSystemMXBean();
        System.out.println("Total RAM：" + mem.getTotalPhysicalMemorySize() / 1024 / 1024 + "MB");
        System.out.println("Available　RAM：" + mem.getFreePhysicalMemorySize() / 1024 / 1024 + "MB");
    }




}
