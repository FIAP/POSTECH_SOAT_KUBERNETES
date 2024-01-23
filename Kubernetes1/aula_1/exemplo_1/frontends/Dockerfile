# Use a imagem oficial do Nginx como base
FROM nginx:alpine

# Copie os arquivos estáticos para a pasta padrão do Nginx
COPY . /usr/share/nginx/html

# Exponha a porta padrão do Nginx (80)
EXPOSE 80

# Inicie o servidor Nginx
CMD ["nginx", "-g", "daemon off;"]
