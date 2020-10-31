#include <stdio.h>
#include <stdlib.h>
#include <memory.h>

char *readStdIn(void) {
    char buffer[1024];

    if (!fgets(buffer, sizeof(buffer), stdin))
        return NULL;

    int len = strlen(buffer);
    if (0 < len && '\n' == buffer[len - 1])
        buffer[--len] = '\0';

    char *str = malloc(len + 1);
    if (!str)
        return NULL;

    return strcpy(str, buffer);
}

int main() {
    printf("Enter your name: ");
    char * name = readStdIn();
    printf("Hello, %s!\n", name);
    return 0;
}
