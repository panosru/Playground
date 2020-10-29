; Simple Hello World! Application

; $ sw_vers -productVersion && system_profiler SPSoftwareDataType
; 10.15.7
; Software:
;
;     System Software Overview:
;
;       System Version: macOS 10.15.7 (19H2)
;       Kernel Version: Darwin 19.6.0
;       Boot Volume: macOS
;       Boot Mode: Normal
;       Computer Name: Panagiotis Hackintosh
;       User Name: Panagiotis Kosmidis (panosru)
;       Secure Virtual Memory: Enabled
;       System Integrity Protection: Disabled
;       Time since boot: 14:37

; assemble
; $ nasm -f macho64 hello_world.asm
; $ ld -macosx_version_min 10.14.0 -lSystem -o hello_world hello_world.o

%define SYSCALL_WRITE 0x2000004
%define SYSCALL_EXIT  0x2000001


global _main

section .data
  message:  db    "Hello World!", 0xA
  .len:     equ   $ - message


section .text

_main:
  mov rax, SYSCALL_WRITE  ; Use the write syscall
  mov rdi, 1              ; Use stdout as the fd
  mov rsi, message        ; Use the message as the buffer
  mov rdx, message.len    ; Supply the length
  syscall                 ; Invoke

  mov rax, SYSCALL_EXIT ; Exit
  mov rdi, 0            ; Return zero
  syscall               ; Invoke
