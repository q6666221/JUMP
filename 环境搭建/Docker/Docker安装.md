# Docker安装
## 1. 卸载旧的Docker
```shell
yum remove docker \
                  docker-client \
                  docker-client-latest \
                  docker-common \
                  docker-latest \
                  docker-latest-logrotate \
                  docker-logrotate \
                  docker-engine
```

## 2. 安装包准备
```shell
yum install -y yum-utils
```

## 3. 设置镜像仓库
```shell
# 语句有错误，建议与官方文档中的对照检查
yum-config-manager \ 
--add-repo \ 
https://mirrors.aliyun.com/linux/centos/docker-ce.repo
# 在国外
https://download.docker.com/linux/centos/docker-ce.repo
```
## 4. 更新yum的索引
```shell
yum makecache fast
```

## 5. 安装docker相关的内容
```shell
yum install docker-ce docker-ce-cli containerd.io
```
## 6. 启动docker
```shell
systemctl start docker
```

## 7. 运行hello world，确认docker是否安装成功
```shell
docker run hello-world
```

## 8. 卸载docker
```shell
# 1. 卸载依赖
yum remove docker-ce docker-ce-cli containerd.io

# 2. 删除依赖
rm -rf /var/lib/docker
```

## 9. docker的默认资源目录
> /var/lib/docker

## 10. 镜像加速
```shell
# 在国外的别配
mkdir -p /etc/docker
tee /etc/docker/daemon.json <<-'EOF'
{
  "registry-mirrors": ["https://kygsnspr.mirror.aliyuncs.com"]
}
EOF
systemctl daemon-reload
systemctl restart docker
```

## Hello World 执行流程
> 在本机寻找镜像 y 执行
> 		 n DockerHub 下载 y 下载 执行
> 		 		  n 报异常 
## 安装问题
```
1. CentOS 8 中安装docker 和 podman 冲突
解决步骤：
1）查看是否安装 podman
rpm -q podman
2）删除podam
dnf remove podman
