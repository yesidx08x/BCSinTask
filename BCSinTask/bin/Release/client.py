from batchcompute import Client, CN_BEIJING
from batchcompute import ClientError
import sys
import socket
access_key_id = '1111111111111111' # your_access_key_id
access_key_secret = '000000000000000000000000000000' # your_access_key_secret
endpoint = CN_BEIJING
cluster_id = "cls-92ek97clnlncseeg8k800c"
group_name = "m16sp6rs2076y216E"
max_item = 2
for arg in sys.argv:
	if arg[0:3].lower()=='-c=':
		cluster_id = arg[3:]
	elif arg[0:3].lower()=='-g=':
		group_name = arg[3:]
	elif arg[0:3].lower()=='-m=':
		max_item = int(arg[3:])
	elif arg[0:3].lower()=='-k=':
		access_key_id = arg[3:]
	elif arg[0:3].lower()=='-s=':
		access_key_secret = arg[3:]
	elif arg[0:3].lower()=='-e=':
		endpoint = eval(arg[3:])
	elif arg.lower()=='-h' or arg.lower()=='/h':
		print '>python client.py [option1=arg1] [option1=arg1] [option1=arg1] ...\n\n'+\
		 '	-h help Print this usage information and exit\n'+\
		 '	-c=cls-xxxxxxxxxxxxxxxxxx Input cluster id from BCS information\n'+\
		 '	-g=xxxxxxxxxxxxx Input group name from BCS information\n'+\
		 '	-m=000000 Input int count of max items from BCS information\n'+\
		 '	-k=XXXXXXXXXX Input access_key_id from BCS information\n'+\
		 '	-s=XXXXXXXXXXXXXXXXXXXX Input access_key_secret from BCS information\n'+\
		 '	-e=XX_XXXXXXX Input end point from BCS information,like CN_BEIJING\n\n'+\
		 'Please see the aliyun documentation for more detailed information.'

def get_bcs_client():
	global access_key_id, access_key_secret
	REGION = "cn-beijing"
	ENDPOINT = "batchcompute-vpc.%s.aliyuncs.com" % REGION
	Client.register_region(REGION, ENDPOINT)
	return Client(ENDPOINT, access_key_id, access_key_secret)
	#return Client(ENDPOINT, ACCESS_ID, ACCESS_KEY, SECURITY_TOKEN)

try:
	#endpoint = CN_BEIJING
	#client = Client(endpoint, access_key_id, access_key_secret, human_readable=True)
	client=get_bcs_client()
	#['cls-92ek97clnlncseeg8k800a','cls-92ek97clnlncseeg8k800b','cls-92ek97clnlncseeg8k800c']
	#group_name = "m16sp6rs2076y216E"
	marker = "" 
	round = 1
	ipL = socket.gethostbyname_ex(socket.gethostname())[2]
	print cluster_id, group_name, marker, max_item
	while marker or round < max_item:
		response = client.list_cluster_instances(cluster_id, group_name, marker, max_item)
		marker = response.NextMarker
		for cluster_instance in response.Items:
			print '>>>Info:delete instance ',cluster_instance.Id, cluster_instance.IpAddress
			#delete instance
			for ip in ipL:
				print '>>>IP :',cluster_instance.IpAddress,'<=>',ip
				if cluster_instance.IpAddress==ip:
					client.delete_cluster_instance(cluster_id, group_name, cluster_instance.Id)
		round += 1
except ClientError, e:
	print(e)
